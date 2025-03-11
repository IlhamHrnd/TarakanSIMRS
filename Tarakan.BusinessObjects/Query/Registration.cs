using System.Data;
using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Filter;
using Tarakan.BusinessObjects.Helper;
using Tarakan.BusinessObjects.Interface;

namespace Tarakan.BusinessObjects.Query
{
    public class Registration : IRegistration
    {
        #region Variabel
        string[] patientIdSearchs = [];
        string regType = string.Empty;
        private string bedStatusPending = string.Empty;
        private string bedStatusBooked = string.Empty;
        private string doctorOnDutyId = string.Empty;
        private bool isShowJobOrder = false;
        private bool isShowOperatingRoom = false;
        private bool isShowBedStatusPending = false;
        private bool isUsingRoomingIn = false;
        private bool isCrmMembershipActive = false;
        int size = 0;
        #endregion

        private readonly IAppParameter _appParameter;
        private readonly IParamedic _paramedic;
        private readonly IServiceUnit _serviceUnit;
        private readonly IVitalSign _vitalSign;

        public Registration(IAppParameter appParameter, IParamedic paramedic, IServiceUnit serviceUnit, IVitalSign vitalSign)
        {
            _appParameter = appParameter;
            _paramedic = paramedic;
            _serviceUnit = serviceUnit;
            _vitalSign = vitalSign;
        }

        [Obsolete]
        public List<RegistrationDto> RegistrationEmr(RegistrationFilter filter, string userId)
        {
            #region Variabel
            var result = new List<RegistrationDto>();
            var dtb = new DataTable();
            size = _appParameter.ParameterInteger("MaxResultRecordEMR");
            isShowBedStatusPending = _appParameter.ParameterBoolean("IsShowBedStatusPending");
            isUsingRoomingIn = _appParameter.ParameterBoolean("IsUsingRoomingIn");
            isCrmMembershipActive = _appParameter.ParameterBoolean("IsCrmMembershipActive");
            bedStatusPending = _appParameter.ParameterString("BedStatusPending");
            bedStatusBooked = _appParameter.ParameterString("BedStatusBooked");
            doctorOnDutyId = _appParameter.ParameterString("DoctorOnDutyId");
            #endregion

            #region Custom
            var au = new EntitySpaces.Generated.AppUser();
            var r = new EntitySpaces.Generated.Registration();
            var su = new EntitySpaces.Generated.ServiceUnit();
            var srQ = new EntitySpaces.Generated.ServiceRoomQuery("srQ");
            var patQ = new EntitySpaces.Generated.PatientQuery("patQ");
            #endregion

            #region Check
            if (string.IsNullOrEmpty(userId))
                return result;

            if (!au.LoadByPrimaryKey(userId))
                return result;

            if (!string.IsNullOrEmpty(filter.RegistrationNo))
            {
                string searchReg = Converter.EscapeQuery(filter.RegistrationNo);
                if (filter.RegistrationNo.Contains("reg", System.StringComparison.CurrentCultureIgnoreCase))
                {
                    if (r.LoadByPrimaryKey(filter.RegistrationNo))
                        regType = r.SRRegistrationType;
                    else
                        return result;
                }
                else
                {
                    if (patientIdSearchs.Length == 0)
                    {
                        patQ.Select(patQ.PatientID)
                            .Where(patQ.Or(patQ.MedicalNo == searchReg, patQ.OldMedicalNo,
                            $"< OR REPLACE({patQ.es.JoinAlias}.MedicalNo, '-', '') LIKE '%{searchReg}%'>",
                            $"< OR REPLACE({patQ.es.JoinAlias}.OldMedicalNo, '-', '') LIKE '%{searchReg}%'>"));
                        var dtPat = patQ.LoadDataTable();
                        if (dtPat.Rows.Count < 25)
                            patientIdSearchs = [.. dtPat.AsEnumerable().Select(r => r.Field<string>("PatientID"))];
                        else
                            patientIdSearchs = [];

                        if (dtPat.Rows.Count == 0)
                            return result;
                    }
                }
            }

            if (!string.IsNullOrEmpty(filter.PatientName) && string.IsNullOrEmpty(filter.RegistrationNo))
            {
                var searchPat = $"%{filter.PatientName}%";
                if (patientIdSearchs.Length == 0)
                {
                    patQ = new EntitySpaces.Generated.PatientQuery("patQ");
                    patQ.Select(patQ.PatientID)
                        .Where($"<RTRIM({patQ.es.JoinAlias}.FirstName+' '+{patQ.es.JoinAlias}.MiddleName)+' '+{patQ.es.JoinAlias}.LastName LIKE '{searchPat}'>");
                    var dtPat = patQ.LoadDataTable();
                    if (dtPat.Rows.Count < 25)
                        patientIdSearchs = [.. dtPat.AsEnumerable().Select(r => r.Field<string>("PatientID"))];
                    else
                        patientIdSearchs = [];

                    if (dtPat.Rows.Count == 0) return result;
                }
            }

            if (!string.IsNullOrEmpty(filter.SRRegistrationType))
            {
                if (!string.IsNullOrEmpty(regType) && regType != filter.SRRegistrationType)
                    return result;

                regType = filter.SRRegistrationType;
            }

            if (!string.IsNullOrEmpty(filter.ServiceUnitID))
            {
                if (!su.LoadByPrimaryKey(filter.ServiceUnitID))
                    return result;

                if (!string.IsNullOrEmpty(regType) && regType != su.SRRegistrationType)
                    return result;

                regType = su.SRRegistrationType;
                isShowJobOrder = su.IsUsingJobOrder ?? false;

                srQ.Select(srQ.RoomName)
                    .Where(srQ.ServiceUnitID == su.ServiceUnitID, srQ.IsOperatingRoom == true, srQ.IsShowOnBookingOT == true);
                isShowOperatingRoom = srQ.LoadDataTable().Rows.Count > 0;
            }
            #endregion

            switch (regType)
            {
                case "IPR":
                    dtb = RegistrationInpatient(filter, size, false, au);
                    size -= dtb.Rows.Count;

                    if (size > 0)
                    {
                        var dtb2 = RegistrationInpatient(filter, size, true, au);
                        dtb.Merge(dtb2);
                        size -= dtb2.Rows.Count;
                    }
                    break;

                case "OPR":
                    dtb = RegistrationNonInpatient(filter, size, [Const.Outpatient], au);
                    size -= dtb.Rows.Count;
                    break;

                case "EMR":
                    dtb = RegistrationNonInpatient(filter, size, [Const.Emergency], au);
                    size -= dtb.Rows.Count;
                    break;

                case "MCU":
                    isShowJobOrder = false;
                    dtb = RegistrationNonInpatient(filter, size, [Const.Medicalcheckup], au);
                    size -= dtb.Rows.Count;

                    if (size > 0)
                    {
                        var dtb2 = RegistrationServiceUnitJobOrderTransaction(filter, size, [Const.Medicalcheckup], au, true);
                        dtb.Merge(dtb2);
                        size -= dtb2.Rows.Count;
                    }

                    if (size > 0)
                    {
                        var dtb2 = RegistrationServiceUnitJobOrderTransaction(filter, size, [Const.Medicalcheckup], au, false);
                        dtb.Merge(dtb2);
                        size -= dtb2.Rows.Count;
                    }
                    break;

                default:
                    dtb = RegistrationNonInpatient(filter, size, [Const.Outpatient, Const.Emergency, Const.Medicalcheckup], au);
                    size -= dtb.Rows.Count;

                    if (size > 0)
                    {
                        var dtb2 = RegistrationInpatient(filter, size, false, au);
                        dtb.Merge(dtb2);
                        size -= dtb2.Rows.Count;
                    }

                    if (size > 0)
                    {
                        var dtb2 = RegistrationInpatient(filter, size, true, au);
                        dtb.Merge(dtb2);
                        size -= dtb2.Rows.Count;
                    }

                    if (size > 0)
                    {
                        var dtb2 = RegistrationServiceUnitJobOrderTransaction(filter, size, [Const.Medicalcheckup], au, true);
                        dtb.Merge(dtb2);
                        size -= dtb2.Rows.Count;
                    }

                    if (size > 0)
                    {
                        var dtb2 = RegistrationServiceUnitJobOrderTransaction(filter, size, [Const.Medicalcheckup], au, false);
                        dtb.Merge(dtb2);
                        size -= dtb2.Rows.Count;
                    }
                    break;
            }

            if (isShowJobOrder && size > 0)
            {
                var dtb2 = RegistrationExamOrder(filter, regType, size, au);
                dtb.Merge(dtb2);
                size -= dtb2.Rows.Count;
            }

            if (isShowOperatingRoom && size > 0)
            {
                var dtb2 = RegistrationServiceUnitBooking(filter, size, "M", au);
                dtb.Merge(dtb2);
                size -= dtb2.Rows.Count;

                if (size > 0 && au.SRUserType == Const.Doctor && !string.IsNullOrEmpty(filter.ParamedicID))
                {
                    var dtb3 = RegistrationServiceUnitBooking(filter, size, "2", au);
                    dtb.Merge(dtb3);
                    size -= dtb3.Rows.Count;

                    if (size > 0)
                    {
                        var dtb4 = RegistrationServiceUnitBooking(filter, size, "3", au);
                        dtb.Merge(dtb4);
                        size -= dtb4.Rows.Count;
                    }

                    if (size > 0)
                    {
                        var dtb4 = RegistrationServiceUnitBooking(filter, size, "4", au);
                        dtb.Merge(dtb4);
                        size -= dtb4.Rows.Count;
                    }

                    if (size > 0)
                    {
                        var dtb4 = RegistrationServiceUnitBooking(filter, size, "A", au);
                        dtb.Merge(dtb4);
                        size -= dtb4.Rows.Count;
                    }
                }
            }

            if (au.SRUserType == Const.Doctor && !string.IsNullOrEmpty(filter.ParamedicTeam) && size > 0)
            {
                switch (filter.ParamedicTeam.ToLower())
                {
                    case "all":
                        var dtb2 = RegistrationServiceUnitParamedic(filter, size, au, string.IsNullOrWhiteSpace(regType) ? [] : [regType], false);
                        dtb.Merge(dtb2);
                        size -= dtb2.Rows.Count;

                        if (size > 0 && isShowBedStatusPending)
                        {
                            var dtb3 = RegistrationServiceUnitParamedic(filter, size, au, string.IsNullOrWhiteSpace(regType) ? [] : [regType], true);
                            dtb.Merge(dtb3);
                            size -= dtb3.Rows.Count;
                        }
                        break;
                }
            }

            var dtFinal = new DataTable();
            if (dtb.Rows.Count > 0)
            {
                dtFinal = dtb.AsEnumerable()
                .GroupBy(row => new
                {
                    RegistrationNo = row.Field<string>("RegistrationNo"),
                    ServiceUnitID = row.Field<string>("ServiceUnitID"),
                    MedicalNo = row.Field<string>("MedicalNo"),
                    PatientID = row.Field<string>("PatientID"),
                    RoomID = row.Field<string>("RoomID"),
                    ParamedicID = row.Field<string>("ParamedicID")
                })
                .Select(group => group.First())
                .CopyToDataTable();
            }

            foreach (DataRow row in dtFinal.Rows)
            {
                var reg = new RegistrationDto
                {
                    RoomName = row["RoomName"] != DBNull.Value ? (string)row["RoomName"] : string.Empty,
                    RegistrationDate = row["RegistrationDate"] != DBNull.Value ? Convert.ToDateTime(row["RegistrationDate"]).ToString(Const.Dateshortmonth) : string.Empty,
                    ServiceUnitID = row["ServiceUnitID"] != DBNull.Value ? row["ServiceUnitID"].ToString() : string.Empty,
                    ParamedicName = row["ParamedicName"] != DBNull.Value ? (string)row["ParamedicName"] : string.Empty,
                    RegistrationNo = row["RegistrationNo"] != DBNull.Value ? (string)row["RegistrationNo"] : string.Empty,
                    MedicalNo = row["MedicalNo"] != DBNull.Value ? (string)row["MedicalNo"] : string.Empty,
                    Sex = row["Sex"] != DBNull.Value ? (string)row["Sex"] : string.Empty,
                    GuarantorName = row["GuarantorName"] != DBNull.Value ? (string)row["GuarantorName"] : string.Empty,
                    PatientID = row["PatientID"] != DBNull.Value ? (string)row["PatientID"] : string.Empty,
                    IsConsul = row["IsConsul"] != DBNull.Value && Convert.ToBoolean(row["IsConsul"]),
                    SRRegistrationType = row["SRRegistrationType"] != DBNull.Value ? (string)row["SRRegistrationType"] : string.Empty,
                    RoomID = row["RoomID"] != DBNull.Value ? (string)row["RoomID"] : string.Empty,
                    RegistrationTime = row["RegistrationTime"] != DBNull.Value ? Convert.ToDateTime(row["RegistrationTime"]).ToString(Const.Hourmin) : string.Empty,
                    IsConfirmedAttendance = row["IsConfirmedAttendance"] != DBNull.Value && Convert.ToBoolean(row["IsConfirmedAttendance"]),
                    IsNewPatient = row["IsNewPatient"] != DBNull.Value && Convert.ToBoolean(row["IsNewPatient"]),
                    IsNeedConfirmationOfAttendance = row["IsNeedConfirmationOfAttendance"] != DBNull.Value && Convert.ToBoolean(row["IsNeedConfirmationOfAttendance"]),
                    DateOfBirth = row["DateOfBirth"] != DBNull.Value ? Convert.ToDateTime(row["DateOfBirth"]) : new DateTime(),
                    SRCovidStatus = row["SRCovidStatus"] != DBNull.Value ? Convert.ToString(row["SRCovidStatus"]) : string.Empty,
                    SRPatientRiskStatus = row["SRPatientRiskStatus"] != DBNull.Value ? Convert.ToString(row["SRPatientRiskStatus"]) : string.Empty,
                    SRDischargeCondition = row["SRDischargeCondition"] != DBNull.Value ? Convert.ToString(row["SRDischargeCondition"]) : string.Empty,
                    RegistrationQue = row["RegistrationQue"] != DBNull.Value ? Convert.ToInt32(row["RegistrationQue"]) : null,
                    //ExternalQueNo = row["ExternalQueNo"] != DBNull.Value ? Convert.ToInt16(row["ExternalQueNo"]) : null,
                    PatientName = row["PatientName"] != DBNull.Value ? (string)row["PatientName"] : string.Empty,
                    ParamedicID = row["ParamedicID"] != DBNull.Value ? (string)row["ParamedicID"] : string.Empty,
                    IsParamedicNotNull = row["IsParamedicNotNull"] != DBNull.Value && Convert.ToBoolean(row["IsParamedicNotNull"]),
                    RowSource = row["RowSource"] != DBNull.Value ? (string)row["RowSource"] : string.Empty,
                    IsDoctorOnDuty = row["IsDoctorOnDuty"] != DBNull.Value && Convert.ToBoolean(row["IsDoctorOnDuty"]),
                    BedID = row["BedID"] != DBNull.Value ? (string)row["BedID"] : string.Empty,
                    SRBedStatus = row["SRBedStatus"] != DBNull.Value ? Convert.ToString(row["SRBedStatus"]) : string.Empty,
                    ReferFrom = row["ReferFrom"] != DBNull.Value && !string.IsNullOrEmpty((string)row["ReferFrom"]) ? $"From : {Convert.ToString(row["ReferFrom"])}" : string.Empty,
                    ReferTo = row["ReferTo"] != DBNull.Value && !string.IsNullOrEmpty((string)row["ReferTo"]) ? $"To : {Convert.ToString(row["ReferTo"])}" : string.Empty,
                    SRTriage = row["SRTriage"] != DBNull.Value ? Convert.ToString(row["SRTriage"]) : string.Empty,
                    IsFinishedAttendance = row["IsFinishedAttendance"] != DBNull.Value && Convert.ToBoolean(row["IsFinishedAttendance"]),
                    IsAlreadyTransfer = row["IsAlreadyTransfer"] != DBNull.Value && Convert.ToBoolean(row["IsAlreadyTransfer"]),
                    TransferNo = row["TransferNo"] != DBNull.Value ? (string)row["TransferNo"] : string.Empty,
                    FromRegistrationNo = row["FromRegistrationNo"] != DBNull.Value ? (string)row["FromRegistrationNo"] : string.Empty,
                    SalutationName = row["SalutationName"] != DBNull.Value ? (string)row["SalutationName"] : string.Empty,
                    IsVipMember = row["IsVipMember"] != DBNull.Value && Convert.ToBoolean(row["IsVipMember"]),
                    Group = row["Group"] != DBNull.Value ? (string)row["Group"] : string.Empty,
                    ReferFromRegistrationType = row["ReferFromRegistrationType"] != DBNull.Value ? (string)row["ReferFromRegistrationType"] : string.Empty
                };
                result.Add(reg);
            }

            return result;
        }

        public string RegistrationTransferStatus(bool isAlreadyTransfer, string transferNo)
        {
            return EntitySpaces.Generated.Registration.RegistrationTransferStatus(isAlreadyTransfer, transferNo);
        }

        [Obsolete]
        public string[] GetMergeRegistration(string regNo)
        {
            return EntitySpaces.Generated.Registration.GetMergeRegistration(regNo);
        }

        [Obsolete]
        public string SoapEntryStatus(string regNo, string parId, string regType)
        {
            return EntitySpaces.Generated.Registration.SoapEntryStatus(regNo, parId, regType);
        }

        public RegistrationDto LoadByPrimaryKey(string regNo)
        {
            var rDto = new RegistrationDto();
            var r = new EntitySpaces.Generated.Registration();
            var pat = new EntitySpaces.Generated.Patient();
            var par = new EntitySpaces.Generated.Paramedic();
            var su = new EntitySpaces.Generated.ServiceUnit();
            var g = new EntitySpaces.Generated.Guarantor();

            if (string.IsNullOrEmpty(regNo))
                return rDto;

            if (!r.LoadByPrimaryKey(regNo))
                return rDto;

            if (r.IsVoid == true)
                return rDto;

            if (!pat.LoadByPrimaryKey(r.PatientID))
                return rDto;

            rDto = new RegistrationDto
            {
                MedicalNo = pat.MedicalNo,
                RegistrationNo = r.RegistrationNo,
                RegistrationDate = Converter.DateFormat(r.RegistrationDate, Const.Dateshortmonth),
                Sex = pat.Sex.ToString().ToLower() == "m" ? "Male" : "Female",
                DateOfBirth = pat.DateOfBirth.HasValue ? pat.DateOfBirth.Value : new DateTime(),
                GuarantorName = g.LoadByPrimaryKey(r.GuarantorID) ? g.GuarantorName : string.Empty,
                BpjsSepNo = r.BpjsSepNo,
                ServiceUnitName = su.LoadByPrimaryKey(r.ServiceUnitID) ? su.ServiceUnitName : string.Empty,
                ParamedicName = par.LoadByPrimaryKey(r.ParamedicID) ? par.ParamedicName : string.Empty,
                PatientName = Converter.GetFullName(pat.FirstName, pat.MiddleName, pat.LastName),
                SRPatientRiskStatus = r.SRPatientRiskStatus
            };

            return rDto;
        }

        #region Registration Query
        [Obsolete]
        private DataTable RegistrationInpatient(RegistrationFilter filter, int maxRecord, bool isTransfer, EntitySpaces.Generated.AppUser au)
        {
            #region Variabel
            var rQ = new EntitySpaces.Generated.RegistrationQuery("rQ");
            var suQ = new EntitySpaces.Generated.ServiceUnitQuery("suQ");
            var srQ = new EntitySpaces.Generated.ServiceRoomQuery("srQ");
            var patQ = new EntitySpaces.Generated.PatientQuery("patQ");
            var gQ = new EntitySpaces.Generated.GuarantorQuery("gQ");
            var salQ = new EntitySpaces.Generated.AppStandardReferenceItemQuery("salQ");
            var parQ = new EntitySpaces.Generated.ParamedicQuery("parQ");
            var bQ = new EntitySpaces.Generated.BedQuery("bQ");
            #endregion

            rQ.InnerJoin(parQ).On(parQ.ParamedicID == rQ.ParamedicID)
                .Top(maxRecord);

            if (!filter.IsIncludeDischarge)
            {
                if (isUsingRoomingIn)
                {
                    rQ.InnerJoin(bQ).On(bQ.BedID == rQ.BedID);
                    if (isShowBedStatusPending)
                        rQ.Where(rQ.DischargeDate.IsNull(), rQ.Or(rQ.IsRoomIn == 1, bQ.RegistrationNo == rQ.RegistrationNo), rQ.Or(bQ.IsNeedConfirmation != true, rQ.And(bQ.IsNeedConfirmation == true)));
                    else
                        rQ.Where(rQ.DischargeDate.IsNull(), rQ.Or(rQ.IsRoomIn == 1, bQ.RegistrationNo == bQ.RegistrationNo), rQ.Or(bQ.IsNeedConfirmation != true, rQ.And(bQ.IsNeedConfirmation == true, bQ.SRBedStatus != bedStatusPending, bQ.SRBedStatus != bedStatusBooked)));
                }
                else
                {
                    rQ.InnerJoin(bQ).On(rQ.RegistrationNo == bQ.RegistrationNo);
                    if (isShowBedStatusPending)
                        rQ.Where(rQ.Or(bQ.IsNeedConfirmation != true, rQ.And(bQ.IsNeedConfirmation == true)));
                    else
                        rQ.Where(rQ.Or(bQ.IsNeedConfirmation != true, rQ.And(bQ.IsNeedConfirmation == true, bQ.SRBedStatus != bedStatusPending, bQ.SRBedStatus != bedStatusBooked)));
                }
            }
            else
            {
                rQ.LeftJoin(bQ).On(rQ.RegistrationNo == bQ.RegistrationNo);
                if (isShowBedStatusPending)
                    rQ.Where(rQ.Or(bQ.RegistrationNo.IsNull(), rQ.RegistrationNo != bQ.RegistrationNo, rQ.And(bQ.IsNeedConfirmation != true, rQ.RegistrationNo == bQ.RegistrationNo),
                        rQ.And(bQ.IsNeedConfirmation == true, rQ.RegistrationNo == bQ.RegistrationNo)));
                else
                    rQ.Where(rQ.Or(bQ.RegistrationNo.IsNull(), rQ.RegistrationNo != bQ.RegistrationNo, rQ.And(bQ.IsNeedConfirmation != true, rQ.RegistrationNo == bQ.RegistrationNo),
                        rQ.And(bQ.IsNeedConfirmation == true, rQ.RegistrationNo == bQ.RegistrationNo, bQ.SRBedStatus != bedStatusPending, bQ.SRBedStatus != bedStatusBooked)));
            }

            rQ.Select(srQ.RoomName, rQ.RegistrationDate, rQ.ServiceUnitID, parQ.ParamedicName, rQ.RegistrationNo, patQ.MedicalNo, patQ.Sex, gQ.GuarantorName, rQ.PatientID, rQ.IsConsul, rQ.SRRegistrationType,
                rQ.RoomID, rQ.BedID, bQ.SRBedStatus, rQ.RegistrationTime, rQ.IsNewPatient, suQ.IsNeedConfirmationOfAttendance, patQ.DateOfBirth, rQ.SRCovidStatus, rQ.SRPatientRiskStatus,
                rQ.SRDischargeCondition, "<RTRIM(patQ.FirstName + ' ' + patQ.MiddleName + '' + patQ.LastName) AS PatientName>", $"<{((au.SRUserType == Const.Doctor || au.SRUserType == Const.Physiotherapy) && !string.IsNullOrWhiteSpace(au.ParamedicID) ? string.Format("'{0}'", au.ParamedicID) : "rQ.ParamedicID")} as ParamedicID>",
                "<'' AS ReferFrom>", "<'' AS ReferFromRegistrationType>", "<'' AS ReferTo>", "<'' AS SRTriage>", "<CASE WHEN rQ.ParamedicID IS NULL THEN CAST(0 AS BIT) ELSE CAST(1 AS BIT) END AS IsParamedicNotNull>",
                "<ISNULL(rQ.IsConfirmedAttendance, 0) AS IsConfirmedAttendance>", "<'false' AS IsDoctorOnDuty>", "<ISNULL(rQ.IsFinishedAttendance, 0) AS IsFinishedAttendance>", "<'true' AS IsAlreadyTransfer>", "<'' AS TransferNo>",
                rQ.FromRegistrationNo.Coalesce("''").As("FromRegistrationNo"), salQ.ItemName.As("SalutationName"));

            if (isCrmMembershipActive)
                rQ.Select("<CASE WHEN ISNULL(rQ.MembershipNo, '') = '' THEN CAST(0 AS BIT) ELSE CAST(1 AS BIT) END AS 'IsVipMember'>");
            else
                rQ.Select(@"<CAST(0 AS BIT) AS 'IsVipMember'>");

            if (isTransfer)
                rQ.Select("<'IPRT' AS RowSource>");
            else
                rQ.Select("<'IPR' AS RowSource>");

            rQ.InnerJoin(srQ).On(srQ.RoomID == rQ.RoomID)
                .InnerJoin(patQ).On(patQ.PatientID == rQ.PatientID)
                .InnerJoin(gQ).On(gQ.GuarantorID == rQ.GuarantorID)
                .InnerJoin(suQ).On(suQ.ServiceUnitID == rQ.ServiceUnitID)
                .LeftJoin(salQ).On(salQ.StandardReferenceID == "Salutation" && patQ.SRSalutation == salQ.ItemID)
                .Where(rQ.SRRegistrationType == Const.Inpatient);

            FilterServiceUnitAndParamedic(filter, rQ, au, true, isTransfer);
            FilterRegistrationAndPatient(filter, rQ, patQ, [Const.Inpatient]);

            if (au.SRUserType == Const.Doctor)
            {
                var rimQ = new EntitySpaces.Generated.RegistrationInfoMedicQuery("rimQ");
                if (filter.IsIncludeIPRSOAPInputted)
                    rQ.LeftJoin(rimQ).On(rimQ.RegistrationNo == rQ.RegistrationNo && rimQ.DateTimeInfo.Date() == DateTime.Now.Date && rimQ.ParamedicID == au.ParamedicID)
                        .Where(rimQ.RegistrationInfoMedicID.IsNull())
                        .Distinct();
            }

            if (!string.IsNullOrEmpty(filter.Smf))
                rQ.Where(rQ.SmfID == filter.Smf);

            rQ.Select(rQ.RegistrationQue, rQ.ExternalQueNo, suQ.ServiceUnitName.As("Group"))
                .OrderBy(rQ.RegistrationDate.Descending, rQ.RegistrationQue.Ascending, rQ.ExternalQueNo.Ascending, rQ.RegistrationTime.Ascending);

            var dt = rQ.LoadDataTable();
            foreach (DataRow dr in dt.Rows)
            {
                RegistrationProcess(dr, true);
            }
            dt.AcceptChanges();
            return dt;
        }

        [Obsolete]
        private DataTable RegistrationNonInpatient(RegistrationFilter filter, int maxRecord, string[] regType, EntitySpaces.Generated.AppUser au)
        {
            #region Variabel
            var rQ = new EntitySpaces.Generated.RegistrationQuery("rQ");
            var srQ = new EntitySpaces.Generated.ServiceRoomQuery("srQ");
            var parQ = new EntitySpaces.Generated.ParamedicQuery("parQ");
            var patQ = new EntitySpaces.Generated.PatientQuery("patQ");
            var suQ = new EntitySpaces.Generated.ServiceUnitQuery("suQ");
            var gQ = new EntitySpaces.Generated.GuarantorQuery("gQ");
            var salQ = new EntitySpaces.Generated.AppStandardReferenceItemQuery("salQ");
            #endregion

            rQ.LeftJoin(srQ).On(rQ.RoomID == srQ.RoomID)
                .InnerJoin(parQ).On(rQ.ParamedicID == parQ.ParamedicID)
                .InnerJoin(patQ).On(patQ.PatientID == rQ.PatientID)
                .InnerJoin(suQ).On(suQ.ServiceUnitID == rQ.ServiceUnitID)
                .InnerJoin(gQ).On(gQ.GuarantorID == rQ.GuarantorID)
                .LeftJoin(salQ).On(salQ.StandardReferenceID == "Salutation" && salQ.ItemID == patQ.SRSalutation);

            rQ.Select(srQ.RoomName, rQ.RegistrationDate, suQ.ServiceUnitID, parQ.ParamedicName, rQ.RegistrationNo, patQ.MedicalNo, patQ.Sex, gQ.GuarantorName, rQ.PatientID, rQ.IsConsul, rQ.SRRegistrationType,
                rQ.RoomID, rQ.RegistrationTime, rQ.IsNewPatient, suQ.IsNeedConfirmationOfAttendance, patQ.DateOfBirth, rQ.SRCovidStatus, rQ.SRPatientRiskStatus, rQ.SRDischargeCondition, rQ.RegistrationQue, rQ.ExternalQueNo,
                "<RTRIM(patQ.FirstName + ' ' + patQ.MiddleName + '' + patQ.LastName) AS PatientName>", $"<{((au.SRUserType == Const.Doctor || au.SRUserType == Const.Physiotherapy) && !string.IsNullOrEmpty(au.ParamedicID) ? $"'{au.ParamedicID}'" : "rQ.ParamedicID")} as ParamedicID>",
                "<CASE WHEN rQ.ParamedicID IS NULL THEN CAST(0 AS BIT) ELSE CAST(1 AS BIT) END AS IsParamedicNotNull>", "<ISNULL(rQ.IsConfirmedAttendance, 0) AS IsConfirmedAttendance>", "<'NIP-'+rQ.SRRegistrationType AS RowSource>", suQ.ServiceUnitName.As("Group"),
                $"<CASE WHEN rQ.SRRegistrationType = 'EMR' THEN (CASE WHEN rQ.ParamedicID = '{doctorOnDutyId}' THEN 'true' ELSE 'false' END) ELSE 'false' END AS IsDoctorOnDuty>", "<'' AS BedID>", "<'' AS SRBedStatus>", "<'' AS ReferFrom>", "<'' AS ReferFromRegistrationType>",
                "<'' AS ReferTo>", "<'' AS SRTriage>", "<ISNULL(rQ.IsFinishedAttendance, 0) AS IsFinishedAttendance>", "<'true' AS IsAlreadyTransfer>", "<'' AS TransferNo>", rQ.FromRegistrationNo.Coalesce("''").As("FromRegistrationNo"), salQ.ItemName.As("SalutationName"));

            if (isCrmMembershipActive)
                rQ.Select("<CASE WHEN ISNULL(rQ.MembershipNo, '') = '' THEN CAST(0 AS BIT) ELSE CAST(1 AS BIT) END AS 'IsVipMember'>");
            else
                rQ.Select("<CAST(0 AS BIT) AS 'IsVipMember'>");

            if (regType.Length == 1)
                rQ.Where(rQ.SRRegistrationType == regType[0]);
            else if (regType.Length > 1)
                rQ.Where(rQ.SRRegistrationType.In(regType));

            FilterServiceUnitAndParamedic(filter, rQ, au, false, false);
            FilterRegistrationAndPatient(filter, rQ, patQ, regType);

            rQ.OrderBy(rQ.RegistrationDate.Descending, rQ.RegistrationQue.Ascending, rQ.ExternalQueNo.Ascending, rQ.RegistrationTime.Ascending)
                .Top(maxRecord);

            var dt = rQ.LoadDataTable();
            foreach (DataRow dr in dt.Rows)
            {
                RegistrationProcess(dr, false);
            }
            dt.AcceptChanges();
            return dt;
        }

        [Obsolete]
        private DataTable RegistrationServiceUnitJobOrderTransaction(RegistrationFilter filter, int maxRecord, string[] regType, EntitySpaces.Generated.AppUser au, bool isServiceUnitTransaction)
        {
            #region Variabel
            var tcQ = new EntitySpaces.Generated.TransChargesQuery("tcQ");
            var tcicQ = new EntitySpaces.Generated.TransChargesItemCompQuery("tcicQ");
            var su1Q = new EntitySpaces.Generated.ServiceUnitQuery("su1Q");
            var su2Q = new EntitySpaces.Generated.ServiceUnitQuery("su2Q");
            var rQ = new EntitySpaces.Generated.RegistrationQuery("rQ");
            var patQ = new EntitySpaces.Generated.PatientQuery("patQ");
            var parQ = new EntitySpaces.Generated.ParamedicQuery("parQ");
            var gQ = new EntitySpaces.Generated.GuarantorQuery("gQ");
            var srQ = new EntitySpaces.Generated.ServiceRoomQuery("srQ");
            var salQ = new EntitySpaces.Generated.AppStandardReferenceItemQuery("salQ");
            #endregion

            tcQ.Top(maxRecord)
                .Distinct();

            tcQ.Select(srQ.RoomName, rQ.RegistrationDate, su1Q.ServiceUnitID, tcicQ.ParamedicID, parQ.ParamedicName, rQ.RegistrationNo, patQ.MedicalNo, patQ.Sex, gQ.GuarantorName, rQ.PatientID,
                rQ.IsConsul, rQ.SRRegistrationType, rQ.RoomID, rQ.RegistrationTime, su2Q.IsNeedConfirmationOfAttendance, rQ.IsNewPatient, patQ.DateOfBirth, rQ.SRCovidStatus, rQ.SRPatientRiskStatus,
                rQ.SRDischargeCondition, rQ.FromRegistrationNo.Coalesce("''").As("FromRegistrationNo"), rQ.FromRegistrationNo.Coalesce("''").As("FromRegistrationNo"), salQ.ItemName.As("SalutationName"), su1Q.ServiceUnitName.As("Group"),
                "<RTRIM(patQ.FirstName + ' ' + patQ.MiddleName + '' + patQ.LastName) AS PatientName>", "<CASE WHEN rQ.ParamedicID IS NULL THEN CAST(0 AS BIT) ELSE CAST(1 AS BIT) END AS IsParamedicNotNull>",
                "<ISNULL(rQ.IsConfirmedAttendance, 0) AS IsConfirmedAttendance>", "<'false' AS IsDoctorOnDuty>", "<ISNULL(rQ.IsFinishedAttendance, 0) AS IsFinishedAttendance>", "<'true' AS IsAlreadyTransfer>", "<'' AS TransferNo>",
                "<'' AS BedID>", "<'' AS SRBedStatus>", "<'' AS ReferFrom>", "<'' AS ReferFromRegistrationType>", "<'' AS ReferTo>", "<'' AS SRTriage>");

            if (isServiceUnitTransaction)
                tcQ.Select("<'MCUSU' AS RowSource>");
            else
                tcQ.Select("<'MCUJO' AS RowSource>");

            if (isCrmMembershipActive)
                tcQ.Select("<CASE WHEN ISNULL(rQ.MembershipNo, '') = '' THEN CAST(0 AS BIT) ELSE CAST(1 AS BIT) END AS 'IsVipMember'>");
            else
                tcQ.Select("<CAST(0 AS BIT) AS 'IsVipMember'>");

            tcQ.InnerJoin(tcicQ).On(tcQ.TransactionNo == tcicQ.TransactionNo)
                .InnerJoin(rQ).On(tcQ.RegistrationNo == rQ.RegistrationNo)
                .InnerJoin(su2Q).On(rQ.ServiceUnitID == su2Q.ServiceUnitID)
                .InnerJoin(patQ).On(rQ.PatientID == patQ.PatientID)
                .InnerJoin(parQ).On(rQ.ParamedicID == parQ.ParamedicID)
                .InnerJoin(gQ).On(rQ.GuarantorID == gQ.GuarantorID)
                .InnerJoin(srQ).On(rQ.RoomID == srQ.RoomID)
                .LeftJoin(salQ).On(salQ.StandardReferenceID == "Salutation" && patQ.SRSalutation == salQ.ItemID);

            if (isServiceUnitTransaction)
                tcQ.InnerJoin(su1Q).On(tcQ.FromServiceUnitID == su1Q.ServiceUnitID);
            else
                tcQ.InnerJoin(su1Q).On(tcQ.ToServiceUnitID == su1Q.ServiceUnitID);

            tcQ.Where(rQ.IsVoid == false, rQ.IsFromDispensary == false, tcQ.IsVoid == false, rQ.IsNonPatient == false);

            if (isServiceUnitTransaction)
                tcQ.Where(rQ.SRRegistrationType == Const.Medicalcheckup, tcicQ.ParamedicID != rQ.ParamedicID, tcQ.IsOrder == false);
            else
                tcQ.Where(tcQ.IsOrder == true);

            if (!isServiceUnitTransaction)
            {
                if (regType.Length == 1)
                    tcQ.Where(rQ.SRRegistrationType == regType[0]);
                else if (regType.Length > 0)
                    tcQ.Where(rQ.SRRegistrationType.In(regType));
            }

            var ausuQ = new EntitySpaces.Generated.AppUserServiceUnitQuery("u");
            if (string.IsNullOrEmpty(filter.ServiceUnitID))
            {
                if (au.SRUserType == Const.Nurse)
                    tcQ.InnerJoin(ausuQ).On(tcQ.FromServiceUnitID == ausuQ.ServiceUnitID && ausuQ.UserID == au.UserID);
            }
            else
                tcQ.Where(tcQ.FromServiceUnitID == filter.ServiceUnitID);

            if (!string.IsNullOrEmpty(filter.ParamedicID))
                tcQ.Where(tcicQ.ParamedicID == filter.ParamedicID);

            if (!string.IsNullOrEmpty(filter.RegistrationNo))
            {
                if (filter.RegistrationNo.Contains("reg", StringComparison.CurrentCultureIgnoreCase))
                    tcQ.Where(tcQ.RegistrationNo == filter.RegistrationNo);
                else
                {
                    var searchText = $"%{filter.RegistrationNo}%";
                    tcQ.Where(patQ.MedicalNo.Like(searchText));
                }
            }

            if (!string.IsNullOrEmpty(filter.PatientName))
            {
                string searchPatient = $"%{Converter.EscapeQuery(filter.PatientName)}%";
                tcQ.Where($"<LTRIM(RTRIM(LTRIM(patQ.FirstName + ' ' + patQ.MiddleName)) + ' ' + patQ.LastName) LIKE '{searchPatient}'>");
            }

            if (!filter.IsIncludeClosed)
                tcQ.Where(rQ.IsClosed == false);

            if (!string.IsNullOrEmpty(filter.ConfirmedAttendanceStatus))
            {
                switch (filter.ConfirmedAttendanceStatus)
                {
                    case "1":
                        tcQ.Where(rQ.IsConfirmedAttendance.IsNotNull(), rQ.IsConfirmedAttendance == true);
                        break;

                    case "0":
                        tcQ.Where(tcQ.Or(rQ.IsConfirmedAttendance.IsNull(), rQ.IsConfirmedAttendance == false));
                        break;
                }
            }

            if (filter.RegistrationDate.HasValue && filter.RegistrationDate.Value.Date != new DateTime(01, 01, 0001))
                tcQ.Where(rQ.RegistrationDate.Date() == filter.RegistrationDate.Value.Date);

            tcQ.Select(rQ.RegistrationQue, rQ.ExternalQueNo)
                .OrderBy(rQ.RegistrationDate.Descending, rQ.RegistrationQue.Ascending, rQ.ExternalQueNo.Ascending, rQ.RegistrationTime.Ascending);

            return tcQ.LoadDataTable();
        }

        [Obsolete]
        private DataTable RegistrationExamOrder(RegistrationFilter filter, string regType, int maxRecord, EntitySpaces.Generated.AppUser au)
        {
            #region Variabel
            var tcQ = new EntitySpaces.Generated.TransChargesQuery("tcQ");
            var rQ = new EntitySpaces.Generated.RegistrationQuery("rQ");
            var patQ = new EntitySpaces.Generated.PatientQuery("patQ");
            var suQ = new EntitySpaces.Generated.ServiceUnitQuery("suQ");
            var gQ = new EntitySpaces.Generated.GuarantorQuery("gQ");
            var parQ = new EntitySpaces.Generated.ParamedicQuery("parQ");
            var salQ = new EntitySpaces.Generated.AppStandardReferenceItemQuery("salQ");
            #endregion

            tcQ.Select(rQ.RegistrationDate, suQ.ServiceUnitID, parQ.ParamedicName, tcQ.RegistrationNo, patQ.MedicalNo, patQ.Sex, gQ.GuarantorName, rQ.PatientID, rQ.IsConsul, rQ.SRRegistrationType, rQ.RoomID, rQ.BedID, rQ.RegistrationQue, rQ.ExternalQueNo,
                rQ.RegistrationTime, rQ.IsNewPatient, suQ.IsNeedConfirmationOfAttendance, patQ.DateOfBirth, rQ.SRCovidStatus, rQ.SRDischargeCondition, suQ.ServiceUnitName.As("Group"),
                $"<{((au.SRUserType == Const.Doctor || au.SRUserType == Const.Physiotherapy) && !string.IsNullOrWhiteSpace(au.ParamedicID) ? $"'{au.ParamedicID}'" : "rQ.ParamedicID")} as ParamedicID>",
                rQ.FromRegistrationNo.Coalesce("''").As("FromRegistrationNo"), salQ.ItemName.As("SalutationName"), "<RTRIM(patQ.FirstName + ' ' + patQ.MiddleName + '' + patQ.LastName) AS PatientName>",
                "<CASE WHEN rQ.ParamedicID IS NULL THEN CAST(0 AS BIT) ELSE CAST(1 AS BIT) END AS IsParamedicNotNull>", "<ISNULL(rQ.IsConfirmedAttendance, 0) AS IsConfirmedAttendance>",
                "<'' AS RoomName>", "<'' AS SRBedStatus>", "<'' AS ReferFrom>", "<'' AS ReferFromRegistrationType>", "<'' AS ReferTo>", "<'' AS SRTriage>", "<'false' AS IsDoctorOnDuty>", "<ISNULL(rQ.IsFinishedAttendance, 0) AS IsFinishedAttendance>",
                "<'true' AS IsAlreadyTransfer>", "<'' AS TransferNo>", "<'JO' AS RowSource>");

            if (isCrmMembershipActive)
                tcQ.Select("<CASE WHEN ISNULL(rQ.MembershipNo, '') = '' THEN CAST(0 AS BIT) ELSE CAST(1 AS BIT) END AS 'IsVipMember'>");
            else
                tcQ.Select("<CAST(0 AS BIT) AS 'IsVipMember'>");

            tcQ.InnerJoin(rQ).On(tcQ.RegistrationNo == rQ.RegistrationNo)
                .InnerJoin(parQ).On(rQ.ParamedicID == parQ.ParamedicID)
                .InnerJoin(patQ).On(rQ.PatientID == patQ.PatientID)
                .InnerJoin(suQ).On(tcQ.ToServiceUnitID == suQ.ServiceUnitID)
                .InnerJoin(gQ).On(rQ.GuarantorID == gQ.GuarantorID)
                .LeftJoin(salQ).On(salQ.StandardReferenceID == "Salutation" && patQ.SRSalutation == salQ.ItemID);

            if (au.SRUserType == Const.Nurse)
            {
                var ausuQ = new EntitySpaces.Generated.AppUserServiceUnitQuery("ausuQ");
                var sutcQ = new EntitySpaces.Generated.ServiceUnitTransactionCodeQuery("sutcQ");

                ausuQ.Select(ausuQ.ServiceUnitID)
                    .InnerJoin(sutcQ).On(sutcQ.ServiceUnitID == ausuQ.ServiceUnitID)
                    .Where(sutcQ.SRTransactionCode == "005", ausuQ.UserID == au.UserID, ausuQ.ServiceUnitID == tcQ.ToServiceUnitID);

                tcQ.Where(tcQ.ToServiceUnitID.In(ausuQ));
            }
            else if (au.SRUserType == Const.Doctor)
            {
                var supQ = new EntitySpaces.Generated.ServiceUnitParamedicQuery("supQ");
                var sutcQ = new EntitySpaces.Generated.ServiceUnitTransactionCodeQuery("sutcQ");
                var su1Q = new EntitySpaces.Generated.ServiceUnitQuery("su1Q");

                supQ.Select(supQ.ServiceUnitID)
                    .InnerJoin(sutcQ).On(sutcQ.ServiceUnitID == supQ.ServiceUnitID)
                    .InnerJoin(su1Q).On(su1Q.ServiceUnitID == supQ.ServiceUnitID)
                    .Where(su1Q.IsAllowAccessPatientWithServiceUnitParamedic == true, sutcQ.SRTransactionCode == "005", supQ.ParamedicID == au.ParamedicID, supQ.ServiceUnitID == tcQ.ToServiceUnitID, supQ.IsActive == true);

                tcQ.Where(tcQ.ToServiceUnitID.In(supQ));

                if (!string.IsNullOrEmpty(filter.ParamedicTeam))
                {
                    switch (filter.ParamedicTeam.ToLower())
                    {
                        case "regtome":
                            tcQ.Where(rQ.ParamedicID == au.ParamedicID);
                            break;
                    }
                }
            }

            if (au.SRUserType != Const.Doctor && !string.IsNullOrEmpty(filter.ParamedicID))
                tcQ.Where(rQ.ParamedicID == filter.ParamedicID);

            if (!string.IsNullOrEmpty(filter.ServiceUnitID))
                tcQ.Where(tcQ.ToServiceUnitID == filter.ServiceUnitID);

            if (regType == Const.Inpatient)
            {
                var bQ = new EntitySpaces.Generated.BedQuery("bQ");
                if (!filter.IsIncludeDischarge)
                    tcQ.InnerJoin(bQ).On(rQ.BedID == bQ.BedID && rQ.RegistrationNo == bQ.RegistrationNo);
                else
                    tcQ.InnerJoin(bQ).On(rQ.BedID == bQ.BedID);

                if (!isShowBedStatusPending)
                    tcQ.Where(tcQ.Or(bQ.IsNeedConfirmation == false, bQ.RegistrationNo != tcQ.RegistrationNo, tcQ.And(bQ.IsNeedConfirmation == true, bQ.SRBedStatus != bedStatusPending)));
                else
                    tcQ.Where(tcQ.Or(bQ.IsNeedConfirmation == false, bQ.RegistrationNo != tcQ.RegistrationNo, tcQ.And(bQ.IsNeedConfirmation == true)));

                tcQ.Where(rQ.SRRegistrationType == Const.Inpatient);
            }
            else
            {
                if (string.IsNullOrEmpty(regType))
                    tcQ.Where(rQ.SRRegistrationType != Const.Inpatient, rQ.SRRegistrationType != Const.Medicalcheckup);
                else
                    tcQ.Where(rQ.SRRegistrationType == regType);

                if (filter.RegistrationDate.HasValue && filter.RegistrationDate.Value.Date != new DateTime(01, 01, 0001))
                {
                    tcQ.Where(rQ.RegistrationDate.Date() == filter.RegistrationDate.Value.Date);

                    if ((!string.IsNullOrEmpty(filter.FromRegistrationTime) && filter.FromRegistrationTime != "00:00") || (!string.IsNullOrEmpty(filter.ToRegistrationTime) && filter.ToRegistrationTime != "00:00"))
                        tcQ.Where(rQ.RegistrationTime.Between(filter.FromRegistrationTime, filter.ToRegistrationTime));
                }
            }

            if (filter.ExamOrderFromDate.HasValue && filter.ExamOrderFromDate.Value.Date != new DateTime(01, 01, 0001))
            {
                if (!filter.ExamOrderToDate.HasValue)
                    tcQ.Where(tcQ.TransactionDate.Between(filter.ExamOrderFromDate.Value, filter.ExamOrderFromDate.Value.AddDays(1)));
                else
                    tcQ.Where(tcQ.TransactionDate.Between(filter.ExamOrderFromDate.Value, filter.ExamOrderToDate.Value.AddDays(1)));
            }

            if (!string.IsNullOrEmpty(filter.RegistrationNo))
            {
                if (filter.RegistrationNo.ToLower().Contains("reg"))
                    tcQ.Where(rQ.RegistrationNo == filter.RegistrationNo);
                else
                {
                    var searchPat = $"%{filter.RegistrationNo}%";
                    tcQ.Where(patQ.MedicalNo.Like(searchPat));
                }
            }

            if (!string.IsNullOrEmpty(filter.PatientName))
            {
                var searchPat = $"%{Converter.EscapeQuery(filter.PatientName)}%";
                tcQ.Where($"<LTRIM(RTRIM(LTRIM(patQ.FirstName + ' ' + patQ.MiddleName)) + ' ' + patQ.LastName) LIKE '{searchPat}'>");
            }

            if (!string.IsNullOrEmpty(filter.Smf))
                tcQ.Where(rQ.SmfID == filter.Smf);

            if (!filter.IsIncludeClosed)
                tcQ.Where(rQ.IsClosed == false);

            tcQ.OrderBy(rQ.RegistrationDate.Descending, rQ.RegistrationQue.Ascending, rQ.ExternalQueNo.Ascending, rQ.RegistrationTime.Ascending)
                .Where(tcQ.IsOrder == true, tcQ.IsApproved == true);

            return tcQ.LoadDataTable();
        }

        [Obsolete]
        private DataTable RegistrationServiceUnitBooking(RegistrationFilter filter, int maxRecord, string paramedicType, EntitySpaces.Generated.AppUser au)
        {
            #region Variabel
            var subQ = new EntitySpaces.Generated.ServiceUnitBookingQuery("subQ");
            var parQ = new EntitySpaces.Generated.ParamedicQuery("parQ");
            var suQ = new EntitySpaces.Generated.ServiceUnitQuery("suQ");
            var srQ = new EntitySpaces.Generated.ServiceRoomQuery("srQ");
            var rQ = new EntitySpaces.Generated.RegistrationQuery("rQ");
            var patQ = new EntitySpaces.Generated.PatientQuery("patQ");
            var gQ = new EntitySpaces.Generated.GuarantorQuery("gQ");
            var salQ = new EntitySpaces.Generated.AppStandardReferenceItemQuery("salQ");
            #endregion

            switch (paramedicType)
            {
                case "M":
                    subQ.LeftJoin(parQ).On(subQ.ParamedicID == parQ.ParamedicID);
                    break;

                case "2":
                    subQ.LeftJoin(parQ).On(subQ.ParamedicID2 == parQ.ParamedicID);
                    break;

                case "3":
                    subQ.LeftJoin(parQ).On(subQ.ParamedicID3 == parQ.ParamedicID);
                    break;

                case "4":
                    subQ.LeftJoin(parQ).On(subQ.ParamedicID4 == parQ.ParamedicID);
                    break;

                case "A":
                    subQ.LeftJoin(parQ).On(subQ.ParamedicIDAnestesi == parQ.ParamedicID);
                    break;
            }

            if (!string.IsNullOrEmpty(filter.ParamedicID))
            {
                switch (paramedicType)
                {
                    case "M":
                        subQ.Where(subQ.ParamedicID == filter.ParamedicID);
                        break;

                    case "2":
                        subQ.Where(subQ.ParamedicID2 == filter.ParamedicID);
                        break;

                    case "3":
                        subQ.Where(subQ.ParamedicID3 == filter.ParamedicID);
                        break;

                    case "4":
                        subQ.Where(subQ.ParamedicID4 == filter.ParamedicID);
                        break;

                    case "A":
                        subQ.Where(subQ.ParamedicIDAnestesi == filter.ParamedicID);
                        break;
                }
            }

            subQ.Top(maxRecord)
                .Distinct();

            subQ.Select(srQ.RoomName, rQ.RegistrationDate, subQ.ServiceUnitID, parQ.ParamedicID, parQ.ParamedicName, subQ.RegistrationNo, patQ.MedicalNo, patQ.Sex, gQ.GuarantorName, rQ.PatientID, rQ.IsConsul, rQ.RegistrationQue, rQ.ExternalQueNo,
                rQ.SRRegistrationType, subQ.RoomID, rQ.RegistrationTime, rQ.IsNewPatient, suQ.IsNeedConfirmationOfAttendance, patQ.DateOfBirth, rQ.SRCovidStatus, rQ.SRPatientRiskStatus, suQ.ServiceUnitName.As("Group"),
                rQ.SRDischargeCondition, rQ.FromRegistrationNo.Coalesce("''").As("FromRegistrationNo"), salQ.ItemName.As("SalutationName"), $"<'OK_{paramedicType}' AS RowSource>", "<ISNULL(rQ.IsConfirmedAttendance, 0) AS IsConfirmedAttendance>",
                "<RTRIM(patQ.FirstName + ' ' + patQ.MiddleName + '' + patQ.LastName) AS PatientName>", "<CASE WHEN rQ.ParamedicID IS NULL THEN CAST(0 AS BIT) ELSE CAST(1 AS BIT) END AS IsParamedicNotNull>", "<'' AS BedID>", "<'' AS SRBedStatus>",
                "<'' AS ReferFrom>", "<'' AS ReferFromRegistrationType>", "<'' AS ReferTo>", "<'' AS SRTriage>", "<'false' AS IsDoctorOnDuty>", "<ISNULL(rQ.IsFinishedAttendance, 0) AS IsFinishedAttendance>", "<'true' AS IsAlreadyTransfer>", "<'' AS TransferNo>");

            if (isCrmMembershipActive)
                subQ.Select("<CASE WHEN ISNULL(rQ.MembershipNo, '') = '' THEN CAST(0 AS BIT) ELSE CAST(1 AS BIT) END AS 'IsVipMember'>");
            else
                subQ.Select("<CAST(0 AS BIT) AS 'IsVipMember'>");

            subQ.LeftJoin(srQ).On(subQ.RoomID == srQ.RoomID)
                .InnerJoin(rQ).On(subQ.RegistrationNo == rQ.RegistrationNo)
                .InnerJoin(patQ).On(rQ.PatientID == patQ.PatientID)
                .InnerJoin(gQ).On(rQ.GuarantorID == gQ.GuarantorID)
                .InnerJoin(suQ).On(subQ.ServiceUnitID == suQ.ServiceUnitID)
                .LeftJoin(salQ).On(salQ.StandardReferenceID == "Salutation" && patQ.SRSalutation == salQ.ItemID);

            if (!string.IsNullOrEmpty(filter.ParamedicTeam))
            {
                switch (filter.ParamedicTeam.ToLower())
                {
                    case "regtome":
                        if (!string.IsNullOrEmpty(filter.ParamedicID))
                            subQ.Where(rQ.ParamedicID == filter.ParamedicID);
                        break;
                }
            }

            if (string.IsNullOrEmpty(filter.ServiceUnitID))
            {
                var ausuQ = new EntitySpaces.Generated.AppUserServiceUnitQuery("ausuQ");
                if (au.SRUserType == Const.Nurse)
                    subQ.InnerJoin(ausuQ).On(ausuQ.ServiceUnitID == subQ.ServiceUnitID && ausuQ.UserID == au.UserID);
            }
            else
                subQ.Where(subQ.ServiceUnitID == filter.ServiceUnitID);

            if (!string.IsNullOrEmpty(filter.RegistrationNo))
            {
                string searchReg = Converter.EscapeQuery(filter.RegistrationNo);
                subQ.Where(subQ.Or(subQ.RegistrationNo == searchReg, patQ.MedicalNo == searchReg, patQ.OldMedicalNo == searchReg,
                        $"< OR REPLACE(patQ.MedicalNo, '-', '') LIKE '%{searchReg}%'>",
                        $"< OR REPLACE(patQ.OldMedicalNo, '-', '') LIKE '%{searchReg}%'>"));
            }

            if (!string.IsNullOrEmpty(filter.PatientName))
            {
                var searchPat = $"%{Converter.EscapeQuery(filter.PatientName)}%";
                subQ.Where($"<LTRIM(RTRIM(LTRIM(patQ.FirstName + ' ' + patQ.MiddleName)) + ' ' + patQ.LastName) LIKE '{searchPat}'>");
            }

            if (filter.RegistrationDate.HasValue && filter.RegistrationDate.Value.Date != new DateTime(01, 01, 0001))
                subQ.Where($"<CAST(RealizationDateTimeFrom as DATE) = CAST('{filter.RegistrationDate.Value.Date}' AS DATE)>");

            subQ.Where(rQ.IsVoid == false)
                .OrderBy(rQ.RegistrationDate.Descending, rQ.RegistrationQue.Ascending, rQ.ExternalQueNo.Ascending, rQ.RegistrationTime.Ascending);

            return subQ.LoadDataTable();
        }

        [Obsolete]
        private DataTable RegistrationServiceUnitParamedic(RegistrationFilter filter, int maxRecord, EntitySpaces.Generated.AppUser au, string[] regType, bool isTransfer)
        {
            if (au.SRUserType != Const.Doctor || filter.ParamedicTeam.ToLower() == "regtome")
                return new DataTable();

            if (!string.IsNullOrEmpty(filter.ServiceUnitID))
            {
                var su = new EntitySpaces.Generated.ServiceUnit();
                if (!su.LoadByPrimaryKey(filter.ServiceUnitID))
                    return new DataTable();

                if (su.IsAllowAccessPatientWithServiceUnitParamedic != true)
                    return new DataTable();

                var sup = new EntitySpaces.Generated.ServiceUnitParamedic();
                if (!sup.LoadByPrimaryKey(au.ParamedicID, su.ServiceUnitID))
                    return new DataTable();
            }

            #region Variabel
            var rQ = new EntitySpaces.Generated.RegistrationQuery("rQ");
            var suQ = new EntitySpaces.Generated.ServiceUnitQuery("suQ");
            var srQ = new EntitySpaces.Generated.ServiceRoomQuery("srQ");
            var parQ = new EntitySpaces.Generated.ParamedicQuery("parQ");
            var patQ = new EntitySpaces.Generated.PatientQuery("patQ");
            var gQ = new EntitySpaces.Generated.GuarantorQuery("gQ");
            var salQ = new EntitySpaces.Generated.AppStandardReferenceItemQuery("salQ");
            var bQ = new EntitySpaces.Generated.BedQuery("bQ");
            #endregion

            rQ.Select(srQ.RoomName, rQ.RegistrationDate, suQ.ServiceUnitID, parQ.ParamedicName, rQ.RegistrationNo, patQ.MedicalNo, patQ.Sex, gQ.GuarantorName, rQ.PatientID, rQ.IsConsul, rQ.RegistrationQue, rQ.ExternalQueNo,
                rQ.SRRegistrationType, rQ.RoomID, rQ.BedID, rQ.RegistrationTime, rQ.IsNewPatient, rQ.SRTriage, suQ.IsNeedConfirmationOfAttendance, patQ.DateOfBirth,
                rQ.SRCovidStatus, rQ.SRPatientRiskStatus, rQ.SRDischargeCondition, "<RTRIM(patQ.FirstName + ' ' + patQ.MiddleName + '' + patQ.LastName) AS PatientName>", suQ.ServiceUnitName.As("Group"),
                $"<'{au.ParamedicID}' as ParamedicID>", "<'' AS SRBedStatus>", "<'' AS ReferFrom>", "<'' AS ReferFromRegistrationType>", "<'' AS ReferTo>",
                "<CASE WHEN rQ.ParamedicID IS NULL THEN CAST(0 AS BIT) ELSE CAST(1 AS BIT) END AS IsParamedicNotNull>", "<ISNULL(rQ.IsConfirmedAttendance, 0) AS IsConfirmedAttendance>",
                rQ.FromRegistrationNo.Coalesce("''").As("FromRegistrationNo"), salQ.ItemName.As("SalutationName"), "<ISNULL(rQ.IsFinishedAttendance, 0) AS IsFinishedAttendance>",
                "<'true' AS IsAlreadyTransfer>", "<'' AS TransferNo>", $"<CASE WHEN rQ.SRRegistrationType = 'EMR' THEN ((CASE WHEN rQ.ParamedicID = '{doctorOnDutyId}' THEN 'true' ELSE 'false' END)) ELSE 'false' END AS IsDoctorOnDuty>");

            rQ.LeftJoin(srQ).On(rQ.RoomID == srQ.RoomID)
                .LeftJoin(parQ).On(rQ.ParamedicID == parQ.ParamedicID)
                .InnerJoin(patQ).On(rQ.PatientID == patQ.PatientID)
                .InnerJoin(gQ).On(rQ.GuarantorID == gQ.GuarantorID)
                .LeftJoin(salQ).On(salQ.StandardReferenceID == "Salutation" && patQ.SRSalutation == salQ.ItemID)
                .InnerJoin(suQ).On(rQ.ServiceUnitID == suQ.ServiceUnitID)
                .LeftJoin(bQ).On(rQ.RegistrationDate == bQ.RegistrationNo);

            if (isTransfer)
                rQ.Select("<'DRJT' AS RowSource>");
            else
                rQ.Select("<'DRJG' AS RowSource>");

            if (isShowBedStatusPending)
                rQ.Where(rQ.Or(bQ.IsNeedConfirmation == false, bQ.IsNeedConfirmation.IsNull(), rQ.And(bQ.IsNeedConfirmation == true, rQ.RegistrationNo == bQ.RegistrationNo)));
            else
                rQ.Where(rQ.Or(bQ.IsNeedConfirmation == false, bQ.IsNeedConfirmation.IsNull(), rQ.And(bQ.IsNeedConfirmation == true, rQ.RegistrationNo == bQ.RegistrationNo, bQ.SRBedStatus != bedStatusPending, bQ.SRBedStatus != bedStatusBooked)));

            if (string.IsNullOrEmpty(filter.ServiceUnitID))
            {
                var supQ = new EntitySpaces.Generated.ServiceUnitParamedicQuery("supQ");
                rQ.InnerJoin(supQ).On(suQ.ServiceUnitID == supQ.ServiceUnitID && suQ.IsAllowAccessPatientWithServiceUnitParamedic == true && supQ.ParamedicID == au.ParamedicID && supQ.IsActive == true);
            }
            else if (isShowBedStatusPending && isTransfer)
            {
                var isInpatient = !string.IsNullOrWhiteSpace(Array.Find(regType, element => element.StartsWith(Const.Inpatient, StringComparison.Ordinal)));
                RegistrationCheckIn(rQ, filter, isInpatient);
            }
            else
                rQ.Where(rQ.ServiceUnitID == filter.ServiceUnitID);

            rQ.Where(rQ.ParamedicID != au.ParamedicID);

            if (regType.Length == 1)
                rQ.Where(rQ.SRRegistrationType == regType[0]);
            else if (regType.Length > 1)
                rQ.Where(rQ.SRRegistrationType.In(regType));

            FilterRegistrationAndPatient(filter, rQ, patQ, regType);

            rQ.OrderBy(rQ.RegistrationDate.Descending, rQ.RegistrationQue.Ascending, rQ.ExternalQueNo.Ascending, rQ.RegistrationTime.Ascending);

            return rQ.LoadDataTable();
        }
        #endregion

        #region Other
        [Obsolete]
        private void FilterServiceUnitAndParamedic(RegistrationFilter filter, EntitySpaces.Generated.RegistrationQuery rQ, EntitySpaces.Generated.AppUser au, bool isInPatient, bool isTransfer)
        {
            if (string.IsNullOrEmpty(filter.ServiceUnitID))
            {
                if (au.SRUserType == Const.Nurse || au.SRUserType == Const.Physiotherapy)
                {
                    var ausuQ = new EntitySpaces.Generated.AppUserServiceUnitQuery("ausuQ");
                    var ptQ = new EntitySpaces.Generated.ParamedicTeamQuery("ptQ");
                    if (au.SRUserType == Const.Physiotherapy && !string.IsNullOrEmpty(au.ParamedicID))
                        rQ.LeftJoin(ausuQ).On(rQ.ServiceUnitID == ausuQ.ServiceUnitID && ausuQ.UserID == au.UserID)
                        .LeftJoin(ptQ).On(rQ.RegistrationNo == ptQ.RegistrationNo)
                        .Where(rQ.Or(ptQ.ParamedicID == au.ParamedicID, ausuQ.UserID == au.UserID));
                    else
                        rQ.InnerJoin(ausuQ).On(rQ.ServiceUnitID == ausuQ.ServiceUnitID && ausuQ.UserID == au.UserID);
                }
            }
            else if (isShowBedStatusPending && isTransfer)
                RegistrationCheckIn(rQ, filter, isInPatient);
            else
                rQ.Where(rQ.ServiceUnitID == filter.ServiceUnitID);

            if (au.SRUserType == Const.Doctor && !string.IsNullOrEmpty(au.ParamedicID))
            {
                var ptQ = new EntitySpaces.Generated.ParamedicTeamQuery("ptQ");
                if (!string.IsNullOrEmpty(filter.ParamedicTeam))
                {
                    switch (filter.ParamedicTeam.ToLower())
                    {
                        case "regtome":
                            rQ.Where(rQ.ParamedicID == au.ParamedicID);
                            break;
                    }
                }
                else if (isInPatient)
                {
                    rQ.InnerJoin(ptQ).On(ptQ.RegistrationNo == rQ.RegistrationNo)
                        .Where(ptQ.ParamedicID == au.ParamedicID);

                    if (!string.IsNullOrEmpty(filter.ParamedicTeam) && filter.ParamedicTeam.ToLower() != "all")
                        rQ.Where(ptQ.SRParamedicTeamStatus == filter.ParamedicTeam);
                }
                else
                    rQ.LeftJoin(ptQ).On(rQ.RegistrationNo == ptQ.RegistrationNo)
                        .Where(rQ.Or(rQ.ParamedicID == au.ParamedicID, ptQ.ParamedicID == au.ParamedicID));
            }
            else if (!string.IsNullOrEmpty(filter.ParamedicID))
                rQ.Where(rQ.ParamedicID == filter.ParamedicID);
        }

        [Obsolete]
        private void FilterRegistrationAndPatient(RegistrationFilter filter, EntitySpaces.Generated.RegistrationQuery rQ, EntitySpaces.Generated.PatientQuery patQ, string[] regType)
        {
            rQ.Where(rQ.IsVoid == false, rQ.IsFromDispensary == false, rQ.IsNonPatient == false);

            if (!string.IsNullOrEmpty(filter.RegistrationNo))
            {
                string searchReg = Converter.EscapeQuery(filter.RegistrationNo);
                if (searchReg.Contains("reg", StringComparison.CurrentCultureIgnoreCase))
                    rQ.Where(rQ.RegistrationNo == searchReg);
                else
                {
                    if (patientIdSearchs.Length > 0)
                        rQ.Where(rQ.PatientID.In(patientIdSearchs));
                    else
                        rQ.Where(rQ.Or(patQ.MedicalNo == searchReg, patQ.OldMedicalNo == searchReg,
                            $"< OR REPLACE({patQ.es.JoinAlias}.MedicalNo, '-', '') LIKE '%{searchReg}%'>",
                            $"< OR REPLACE({patQ.es.JoinAlias}.OldMedicalNo, '-', '') LIKE '%{searchReg}%'>"));
                }
            }

            if (!string.IsNullOrEmpty(filter.PatientName) && string.IsNullOrEmpty(filter.RegistrationNo))
            {
                var searchPat = $"%{filter.PatientName}%";
                if (patientIdSearchs.Length > 0)
                    rQ.Where(rQ.PatientID.In(patientIdSearchs));
                else
                    rQ.Where($"<RTRIM({patQ.es.JoinAlias}.FirstName+' '+{patQ.es.JoinAlias}.MiddleName)+' '+{patQ.es.JoinAlias}.LastName LIKE '{searchPat}'>");
            }
            var isIncludeInPatient = !string.IsNullOrWhiteSpace(Array.Find(regType, element => element.StartsWith(Const.Inpatient, StringComparison.Ordinal)));
            if ((filter.RegistrationDate.HasValue && filter.RegistrationDate.Value.Date != new DateTime(01, 01, 0001)) && !(regType.Length == 1 && isIncludeInPatient))
            {
                if (regType.Length == 0 || (regType.Length > 1 && isIncludeInPatient))
                    rQ.Where(rQ.Or(rQ.SRRegistrationType == Const.Inpatient, rQ.RegistrationDate == filter.RegistrationDate.Value.Date));
                else
                    rQ.Where(rQ.RegistrationDate.Date() == filter.RegistrationDate.Value.Date);

                if ((!string.IsNullOrEmpty(filter.FromRegistrationTime) && filter.FromRegistrationTime != "00:00") || (!string.IsNullOrEmpty(filter.ToRegistrationTime) && filter.ToRegistrationTime != "00:00"))
                    rQ.Where(rQ.Or(rQ.SRRegistrationType == Const.Inpatient, rQ.RegistrationTime.Between(filter.FromRegistrationTime, filter.ToRegistrationTime)));
            }

            if (!filter.IsIncludeClosed)
                rQ.Where(rQ.IsClosed == false);

            if (!filter.IsIncludeNonIPRSOAPInputted)
            {
                if (regType.Length != 1 || regType[0] != Const.Inpatient && regType[0] != Const.Emergency)
                {
                    var isIncludeEmergencyPatient = !string.IsNullOrWhiteSpace(Array.Find(regType, element => element.StartsWith(Const.Emergency, StringComparison.Ordinal)));

                    var rimQ = new EntitySpaces.Generated.RegistrationInfoMedicQuery("rimQ");
                    rimQ.Select(rimQ.RegistrationNo)
                        .Where(rimQ.RegistrationNo == rQ.RegistrationNo);

                    if (regType.Length == 0 || (regType.Length > 1 && isIncludeEmergencyPatient && isIncludeInPatient))
                        rQ.Where(rQ.Or(rQ.SRRegistrationType == Const.Inpatient, rQ.SRRegistrationType == Const.Emergency, rQ.RegistrationNo.NotIn(rimQ)));
                    else if (regType.Length > 1 && isIncludeEmergencyPatient)
                        rQ.Where(rQ.Or(rQ.SRRegistrationType == Const.Emergency, rQ.RegistrationNo.NotIn(rimQ)));
                    else if (regType.Length > 1 && isIncludeInPatient)
                        rQ.Where(rQ.Or(rQ.SRRegistrationType == Const.Emergency, rimQ.RegistrationNo.NotIn(rimQ)));
                    else if (!isIncludeInPatient && !isIncludeEmergencyPatient)
                        rQ.Where(rQ.RegistrationNo.NotIn(rimQ));
                }
            }

            if (!string.IsNullOrEmpty(filter.ConfirmedAttendanceStatus))
            {
                if (regType.Length == 0 || (regType.Length > 1 && isIncludeInPatient))
                {
                    switch (filter.ConfirmedAttendanceStatus)
                    {
                        case "1":
                            rQ.Where(rQ.Or(rQ.SRRegistrationType == Const.Inpatient, rQ.IsConfirmedAttendance.IsNotNull(), rQ.IsConfirmedAttendance == true));
                            break;

                        case "0":
                            rQ.Where(rQ.Or(rQ.SRRegistrationType == Const.Inpatient, rQ.Or(rQ.IsConfirmedAttendance.IsNull(), rQ.IsConfirmedAttendance == false)));
                            break;
                    }
                }
                else if (!isIncludeInPatient)
                    switch (filter.ConfirmedAttendanceStatus)
                    {
                        case "1":
                            rQ.Where(rQ.IsConfirmedAttendance.IsNotNull(), rQ.IsConfirmedAttendance == true);
                            break;

                        case "2":
                            rQ.Where(rQ.Or(rQ.IsConfirmedAttendance.IsNull(), rQ.IsConfirmedAttendance == false));
                            break;
                    }
            }
        }

        [Obsolete]
        private void RegistrationCheckIn(EntitySpaces.Generated.RegistrationQuery rQ, RegistrationFilter filter, bool isInpatient)
        {
            var ptQ = new EntitySpaces.Generated.PatientTransferQuery("ptQ");
            var bQ = new EntitySpaces.Generated.BedQuery("bQ");
            var pthQ = new EntitySpaces.Generated.PatientTransferHistoryQuery("pthQ");
            rQ.InnerJoin(ptQ).On(ptQ.RegistrationNo == rQ.RegistrationNo && ptQ.IsApprove == true && ptQ.FromServiceUnitID == filter.ServiceUnitID) 
                .InnerJoin(pthQ).On(pthQ.RegistrationNo == ptQ.RegistrationNo && pthQ.ServiceUnitID == ptQ.ToServiceUnitID && pthQ.BedID == ptQ.ToBedID)
                .Where(rQ.Or(ptQ.IsValidated.IsNull(), ptQ.IsValidated == false), pthQ.DateOfExit.IsNull());

            if (!isInpatient)
                rQ.InnerJoin(bQ).On(bQ.BedID == ptQ.ToBedID && bQ.IsNeedConfirmation == true);
        }

        [Obsolete]
        private DataRow RegistrationProcess(DataRow dr, bool isInpatient)
        {
            if (isInpatient)
            {
                var dt = PatientNotCheckIn((string)dr["RegistrationNo"], (string)dr["ServiceUnitID"], (string)dr["BedID"]);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        var su = new EntitySpaces.Generated.ServiceUnit();
                        if (su.LoadByPrimaryKey((string)item["FromServiceUnitID"]))
                        {
                            dr["Group"] = su.ServiceUnitName;
                            dr["ServiceUnitID"] = su.ServiceUnitID;
                            dr["IsAlreadyTransfer"] = false;
                            if (item["TransferNo"] != DBNull.Value || !string.IsNullOrEmpty((string)item["TransferNo"]))
                                dr["TransferNo"] = item["TransferNo"];
                        }
                    }
                }
            }
            else
            {
                var referTo = string.Empty;
                if (dr["FromRegistrationNo"] != null && !string.IsNullOrEmpty((string)dr["FromRegistrationNo"]))
                {
                    var r = new EntitySpaces.Generated.Registration();
                    if (r.LoadByPrimaryKey((string)dr["FromRegistrationNo"]))
                    {
                        dr["ReferFrom"] = $"({_paramedic.GetParamedicName(r.ParamedicID)}) ({_serviceUnit.GetServiceUnitName(r.ServiceUnitID)})";
                        dr["ReferFromRegistrationType"] = r.SRRegistrationType;
                    }

                    var mbQ = new EntitySpaces.Generated.MergeBillingQuery("mbQ");
                    mbQ.Select(mbQ.RegistrationNo)
                        .Where(mbQ.FromRegistrationNo == (string)dr["FromRegistrationNo"]);

                    foreach (DataRow row in mbQ.LoadDataTable().Rows)
                    {
                        r = new EntitySpaces.Generated.Registration();
                        if (r.LoadByPrimaryKey((string)row["RegistrationNo"]))
                        {
                            if (r.IsVoid == false && !string.IsNullOrEmpty(r.ParamedicID))
                            {
                                var p = new EntitySpaces.Generated.Paramedic();
                                if (p.LoadByPrimaryKey(r.ParamedicID))
                                    referTo += $"{p.ParamedicName};";
                            }
                        }
                    }
                }

                if (!string.IsNullOrEmpty(referTo))
                    dr["ReferTo"] = referTo.Remove(referTo.Length - 1);

                if (_vitalSign.LastVitalSignDate((string)dr["RegistrationNo"], (string)dr["FromRegistrationNo"]) != new DateTime(1900, 1, 1))
                    dr["SRTriage"] = "99";
            }
            return dr;
        }

        [Obsolete]
        private DataTable PatientNotCheckIn(string registrationNo, string serviceunitID, string bedID)
        {
            var ptQ = new EntitySpaces.Generated.PatientTransferQuery("ptQ");
            var bQ = new EntitySpaces.Generated.BedQuery("bQ");
            var pthQ = new EntitySpaces.Generated.PatientTransferHistoryQuery("pthQ");
            ptQ.InnerJoin(bQ).On(bQ.BedID == ptQ.ToBedID && bQ.IsNeedConfirmation == true)
                .InnerJoin(pthQ).On(pthQ.RegistrationNo == ptQ.RegistrationNo && pthQ.ServiceUnitID == ptQ.ToServiceUnitID && pthQ.BedID == ptQ.ToBedID)
                .Where(ptQ.RegistrationNo == registrationNo, ptQ.ToServiceUnitID == serviceunitID, ptQ.IsApprove == true,
                ptQ.Or(ptQ.IsValidated.IsNull(), ptQ.IsValidated == false), pthQ.DateOfExit.IsNull(), ptQ.ToBedID == bedID)
                .Select(ptQ.TransferNo, ptQ.FromServiceUnitID);
            return ptQ.LoadDataTable();
        }
        #endregion
    }
}
