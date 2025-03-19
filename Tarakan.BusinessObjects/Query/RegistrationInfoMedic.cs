using EntitySpaces.DynamicQuery;
using System.Data;
using System.Text;
using Tarakan.BusinessObjects.Custom;
using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Helper;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class RegistrationInfoMedic : BaseQuery, IRegistrationInfoMedic
    {
        private readonly IRegistration _registration;
        private readonly IAppParameter _appParameter;
        private readonly IPatientTransferHistory _patientTransferHistory;
        private readonly IParamedic _paramedic;
        private readonly IServiceUnit _serviceUnit;
        private readonly IAppStandardReferenceItem _appStandardReferenceItem;
        private readonly IAppUser _appUser;
        private readonly IParamedicConsultRefer _paramedicConsultRefer;
        private readonly IPatientHealthRecord _patientHealthRecord;
        private readonly IPatientAssessment _patientAssessment;
        public RegistrationInfoMedic(AppDbContext context, IRegistration registration, IAppParameter appParameter, IPatientTransferHistory patientTransferHistory, IParamedic paramedic, IServiceUnit serviceUnit,
            IAppStandardReferenceItem appStandardReferenceItem, IAppUser appUser, IParamedicConsultRefer paramedicConsultRefer, IPatientHealthRecord patientHealthRecord, IPatientAssessment patientAssessment) : base(context)
        {
            _registration = registration;
            _appParameter = appParameter;
            _patientTransferHistory = patientTransferHistory;
            _paramedic = paramedic;
            _serviceUnit = serviceUnit;
            _appStandardReferenceItem = appStandardReferenceItem;
            _appUser = appUser;
            _paramedicConsultRefer = paramedicConsultRefer;
            _patientHealthRecord = patientHealthRecord;
            _patientAssessment = patientAssessment;
        }

        [Obsolete]
        public List<RegistrationInfoMedicDto> IntegratedNotes(string regType, string regNo, List<string> regNoList, string patId, string filter, string parId)
        {
            #region Variabel
            var dtb = new DataTable();
            var lastRegNos = _registration.RegistrationNos(patId, _appParameter.ParameterInteger("EmrHistoryRegistrationCount"), regNo);
            #endregion

            #region Patient Assessment
            var rimQ = new EntitySpaces.Generated.RegistrationInfoMedicQuery("rimQ");
            var paQ = new EntitySpaces.Generated.PatientAssessmentQuery("paQ");
            var asriQ = new EntitySpaces.Generated.AppStandardReferenceItemQuery("asriQ");
            var rQ = new EntitySpaces.Generated.RegistrationQuery("rQ");

            rimQ.Select(rimQ.RegistrationInfoMedicID, rimQ.RegistrationNo, rimQ.ParamedicID, rimQ.SRMedicalNotesInputType, rimQ.DateTimeInfo, rimQ.Info1, rimQ.Info2, rimQ.Info3, rimQ.Info4, rimQ.Info5, rimQ.IsApproved.Coalesce("CONVERT(bit,0)").As("IsApproved"), rimQ.ApprovedDatetime, rimQ.ApprovedByUserID,
                rimQ.CreatedDateTime, rimQ.CreatedByUserID, rimQ.IsDeleted.Coalesce("CONVERT(bit,0)").As("IsDeleted"), rimQ.ServiceUnitID, rimQ.AttendingNotes, paQ.SRAssessmentType, paQ.IsInitialAssessment, "<CAST(0 as bit) as IsFromAskep>", asriQ.ItemName.Coalesce("''").As("AssessmentTypeName"),
                rimQ.SRUserType, rimQ.PpaInstruction, "<'' as ReferenceToPhrNo>", rimQ.IsCreatedByUserDpjp, rimQ.PrescriptionCurrentDay, rimQ.DpjpNotes, rimQ.ReferenceNo, rQ.FromRegistrationNo,
                "<'' as SubmitBy>", "<'' as ReceiveBy>", "<'' as TemplateID>", "<'' as SRNursingDiagnosaLevel>", "<'' as SRNursingCarePlanning>")
                .LeftJoin(paQ).On(rimQ.RegistrationInfoMedicID == paQ.RegistrationInfoMedicID)
                .LeftJoin(asriQ).On(paQ.SRAssessmentType == asriQ.ItemID && asriQ.StandardReferenceID == "AssessmentType")
                .InnerJoin(rQ).On(rimQ.RegistrationNo == rQ.RegistrationNo)
                .OrderBy(rimQ.RegistrationInfoMedicID.Descending);

            if (regType == Const.Inpatient)
            {
                if (regNoList.Count > 1)
                    rimQ.Where(rimQ.RegistrationNo.In(regNoList));
                else
                    rimQ.Where(rimQ.RegistrationNo == regNoList[0]);
            }
            else
            {
                if (lastRegNos.Count == 0)
                    rimQ.Where(rimQ.RegistrationNo == lastRegNos[0]);
                else
                    rimQ.Where(rimQ.RegistrationNo.In(lastRegNos));
            }

            if (!string.IsNullOrEmpty(filter))
                rimQ.Where(rimQ.SRUserType == filter);

            dtb = rimQ.LoadDataTable();
            #endregion

            #region Nursing Notes
            var ndtQ = new EntitySpaces.Generated.NursingDiagnosaTransDTQuery("ndtQ");
            var nthQ = new EntitySpaces.Generated.NursingTransHDQuery("nthQ");
            rQ = new EntitySpaces.Generated.RegistrationQuery("rQ");

            ndtQ.Select(ndtQ.Id.Cast(esCastType.String).As("RegistrationInfoMedicID"), nthQ.RegistrationNo, ndtQ.ParamedicID, ndtQ.ExecuteDateTime.As("DateTimeInfo"), ndtQ.A.As("Info3"), ndtQ.P.As("Info4"), ndtQ.Info5,
                ndtQ.IsApproved.Coalesce("CONVERT(bit,0)").As("IsApproved"), ndtQ.ApprovedDatetime, ndtQ.ApprovedByUserID, ndtQ.CreateDateTime.As("CreatedDateTime"), ndtQ.CreateByUserID.As("CreatedByUserID"), ndtQ.IsDeleted.Coalesce("CONVERT(bit,0)").As("IsDeleted"),
                "<CASE WHEN ndtQ.NursingDiagnosaName='S B A R' THEN 'SBAR' WHEN ndtQ.NursingDiagnosaName='ADIME' THEN 'ADIME' WHEN ndtQ.NursingDiagnosaName = 'S O A P' OR ndtQ.SRNursingDiagnosaLevel = '40' THEN 'SOAP' WHEN ndtQ.NursingDiagnosaName = 'Handover Patient' THEN ndtQ.NursingDiagnosaName  ELSE 'Notes' END as SRMedicalNotesInputType>",
                "<CASE WHEN ndtQ.NursingDiagnosaName='S B A R' OR ndtQ.NursingDiagnosaName = 'ADIME' OR ndtQ.NursingDiagnosaName = 'S O A P' OR ndtQ.NursingDiagnosaName = 'Handover Patient' OR ndtQ.SRNursingDiagnosaLevel = '40' THEN S ELSE ndtQ.NursingDiagnosaName END as Info1>",
                "<CASE WHEN ndtQ.NursingDiagnosaName='S B A R' OR ndtQ.NursingDiagnosaName = 'ADIME' OR ndtQ.NursingDiagnosaName = 'S O A P' OR ndtQ.NursingDiagnosaName = 'Handover Patient' OR ndtQ.SRNursingDiagnosaLevel = '40' THEN O ELSE ndtQ.Respond END as Info2>",
                "<'' as ServiceUnitID>", "<'' as AttendingNotes>", "<'NurseNotes' as SRAssessmentType>", "<CAST(0 as bit) as IsInitialAssessment>", "<CAST(1 as bit) as IsFromAskep>", "<'' as AssessmentTypeName>", "<CAST(0 as bit) as IsCreatedByUserDpjp>",
                "<CAST(ISNULL(ndtQ.TemplateID,0) as varchar(10)) as TemplateID>", "<'' as ReferenceNo>",
                ndtQ.SRUserType, ndtQ.PpaInstruction, ndtQ.ReferenceToPhrNo, ndtQ.PrescriptionCurrentDay, ndtQ.SubmitBy, ndtQ.ReceiveBy, ndtQ.DpjpNotes, ndtQ.SRNursingDiagnosaLevel, ndtQ.SRNursingCarePlanning, rQ.FromRegistrationNo)
                .InnerJoin(nthQ).On(nthQ.TransactionNo == ndtQ.TransactionNo)
                .InnerJoin(rQ).On(rQ.RegistrationNo == nthQ.RegistrationNo);

            if (regType == Const.Inpatient)
            {
                if (regNoList.Count > 1)
                    ndtQ.Where(nthQ.RegistrationNo.In(regNoList));
                else
                    ndtQ.Where(nthQ.RegistrationNo == regNoList[0]);
            }
            else
            {
                if (lastRegNos.Count == 1)
                    ndtQ.Where(nthQ.RegistrationNo == lastRegNos[0]);
                else
                    ndtQ.Where(nthQ.RegistrationNo.In(lastRegNos));
            }

            if (!string.IsNullOrEmpty(filter))
                ndtQ.Where(ndtQ.SRUserType == filter);

            ndtQ.Where(ndtQ.Or(ndtQ.SRNursingDiagnosaLevel == "31", ndtQ.SRNursingDiagnosaLevel == "40"));
            var dtAskep = ndtQ.LoadDataTable();
            foreach (var r in dtAskep.AsEnumerable()
                .Where(dr => dr.Field<string>("SRNursingDiagnosaLevel") == "40" & dr.Field<string>("SRNursingCarePlanning") != "01"))
            {
                var nicEval = EntitySpaces.Generated.NursingDiagnosaTransDT.DetailEvaluationByEvaluationIdHtml(Convert.ToInt32(r["RegistrationInfoMedicID"]));
                if (r["SRMedicalNotesInputType"].ToString() == "ADIME")
                    r["Info3"] = r["Info3"].ToString() + nicEval;
                else
                    r["Info4"] = r["Info4"].ToString() + nicEval;
            }
            #endregion

            #region Process
            dtb.Merge(dtAskep);
            dtb.Columns.Add(new DataColumn("ServiceUnitName", typeof(string)));
            dtb.Columns.Add(new DataColumn("ParamedicName", typeof(string)));
            dtb.Columns.Add(new DataColumn("MedicalInputType", typeof(string)));
            dtb.Columns.Add(new DataColumn("Result", typeof(string)));
            dtb.Columns.Add(new DataColumn("CreatedByUserName", typeof(string)));
            dtb.Columns.Add(new DataColumn("DateTimeInfoStr", typeof(string)));
            dtb.Columns.Add(new DataColumn("AdditionalInfo", typeof(string)));
            dtb.DefaultView.Sort = "CreatedDateTime DESC";
            dtb.DefaultView.ToTable();

            foreach (DataRow dr in dtb.Rows)
            {
                string SRMedicalNotesInputType = (string)dr["SRMedicalNotesInputType"];
                string medicalType = string.Empty;
                if (!string.IsNullOrEmpty(SRMedicalNotesInputType))
                    medicalType = _appStandardReferenceItem.GetItemName("MedicalNotesInputType", (string)dr["SRMedicalNotesInputType"]);

                if (string.IsNullOrEmpty(medicalType))
                {
                    switch (SRMedicalNotesInputType)
                    {
                        case "CON":
                            medicalType = "Consult";
                            break;

                        case "MDS":
                            medicalType = "Medical Discharge Summary";
                            break;

                        case "Notes":
                            medicalType = "Notes";
                            break;
                    }
                }

                if (!string.IsNullOrEmpty(medicalType))
                    dr["MedicalInputType"] = medicalType;

                var sbNote = new StringBuilder();
                sbNote.AppendLine("<table style=\"width:100%\">");
                switch (SRMedicalNotesInputType)
                {
                    case "SBAR":
                    case "SOAP":
                    case "ADIME":
                    case "Handover Patient":
                        if (SRMedicalNotesInputType == "Handover Patient")
                            SRMedicalNotesInputType = "SOAP";

                        var collWidth = dr["SubmitBy"] != DBNull.Value && dr["ReceiveBy"] != DBNull.Value ? 50 : 10;
                        sbNote.AppendFormat($"<tr><td class='label' valign='top' style='font-weight: bold;width:{collWidth}px; padding-left:2px'>{SRMedicalNotesInputType.Substring(0, 1)}:</td><td valign='top'>{Converter.ReplaceWitBreakLineHTML((string)dr["Info1"])}</td></tr>");
                        sbNote.AppendLine();

                        sbNote.AppendFormat($"<tr><td class='label' valign='top' style='font-weight: bold;width:{collWidth}px; padding-left:2px'>{SRMedicalNotesInputType.Substring(1, 1)}:</td><td valign='top'>{Converter.ReplaceWitBreakLineHTML((string)dr["Info2"])}</td></tr>");
                        sbNote.AppendLine();

                        sbNote.AppendFormat($"<tr><td class='label' valign='top' style='font-weight: bold;width:{collWidth}px; padding-left:2px'>{SRMedicalNotesInputType.Substring(2, 1)}:</td><td valign='top'>{Converter.ReplaceWitBreakLineHTML((string)dr["Info3"])}</td></tr>");
                        sbNote.AppendLine();

                        string planning = Converter.FormatToHtml(dr["Info4"]);
                        var isFromAssessment = dr["SRAssessmentType"] != DBNull.Value && !string.IsNullOrEmpty((string)dr["SRAssessmentType"]) && !"NurseNotes".Equals(dr["SRAssessmentType"]);
                        if (SRMedicalNotesInputType == "SOAP" && isFromAssessment)
                            planning = dr["PrescriptionCurrentDay"] != DBNull.Value || !string.IsNullOrEmpty((string)dr["PrescriptionCurrentDay"])
                                ? $"{Converter.FormatToHtml(dr["Info4"])}<br/><br/>{Converter.FormatToHtml(dr["PrescriptionCurrentDay"])}"
                                : Converter.FormatToHtml(dr["Info4"]);

                        sbNote.AppendFormat($"<tr><td class='label' valign='top' style='font-weight: bold; width:{collWidth}px;padding-left:2px'>{SRMedicalNotesInputType.Substring(3, 1)}:</td><td valign='top'>{planning}</td></tr>");

                        if (SRMedicalNotesInputType == "SOAP" && !isFromAssessment)
                        {
                            var ppaInstruction = Converter.FormatToHtml(dr["PpaInstruction"]);
                            if (!"NurseNotes".Equals(dr["SRAssessmentType"]) && !isFromAssessment && (dr["PrescriptionCurrentDay"] != DBNull.Value || !string.IsNullOrEmpty(dr["PrescriptionCurrentDay"].ToString())))
                                ppaInstruction = $"{Converter.FormatToHtml(dr["PpaInstruction"])}<br/><br/>{Converter.FormatToHtml(dr["PrescriptionCurrentDay"])}";

                            if (!string.IsNullOrEmpty(ppaInstruction))
                                sbNote.AppendFormat($"<tr><td class='label' valign='top' style='font-weight: bold;width:{collWidth}px; padding-left:2px'>I:</td><td valign='top'>{ppaInstruction}</td></tr>");

                            if (dr["Info5"] != DBNull.Value)
                            {
                                var info = Converter.ReplaceWitBreakLineHTML((string)dr["Info5"]);
                                if (!string.IsNullOrEmpty(info))
                                {
                                    sbNote.AppendFormat($"<tr><td class='label' valign='top' style='font-weight: bold;width:{collWidth}px;padding-left:2px'>{"E"}:</td><td valign='top'>{info}</td></tr>");
                                    sbNote.AppendLine();
                                }
                            }

                            if (dr["SubmitBy"] != DBNull.Value)
                            {
                                string info = Converter.ReplaceWitBreakLineHTML((string)dr["SubmitBy"]);
                                if (!string.IsNullOrEmpty(info))
                                {
                                    var au = _appUser.AppUserLoad(info);
                                    var submitByValue = _appUser.AppUserString(au.au.UserName, info);
                                    sbNote.AppendFormat($"<tr><td class='label' valign='top' style='font-weight: bold;width:{collWidth}px; padding-left:2px'>{"Submit By"}:</td><td valign='top'>{submitByValue}</td></tr>");
                                    sbNote.AppendLine();
                                }
                            }

                            if (dr["ReceiveBy"] != DBNull.Value)
                            {
                                string info = Converter.ReplaceWitBreakLineHTML((string)dr["ReceiveBy"]);
                                if (!string.IsNullOrEmpty(info))
                                {
                                    var au = _appUser.AppUserLoad(info);
                                    var receiveByString = _appUser.AppUserString(au.au.UserName, info);
                                    sbNote.AppendFormat($"<tr><td class='label' valign='top' style='font-weight: bold;width:{collWidth}px; padding-left:2px'>{"Receive By"}:</td><td valign='top'>{receiveByString}</td></tr>");
                                    sbNote.AppendLine();
                                }
                            }
                        }
                        else if (SRMedicalNotesInputType == "Handover Patient")
                        {
                            if (dr["PpaInstruction"] != DBNull.Value)
                            {
                                var info = Converter.ReplaceWitBreakLineHTML((string)dr["PpaInstruction"]);
                                sbNote.AppendFormat($"<tr><td class='label' valign='top' style='font-weight: bold;width:{collWidth}px; padding-left:2px'>I:</td><td valign='top'>{info}</td></tr>");
                                sbNote.AppendLine();
                            }

                            if (dr["SubmitBy"] != DBNull.Value)
                            {
                                string info = Converter.ReplaceWitBreakLineHTML((string)dr["SubmitBy"]);
                                sbNote.AppendFormat($"<tr><td class='label' valign='top' style='font-weight: bold;width:{collWidth}px; padding-left:2px'>{"Submit By"}:</td><td valign='top'>{info}</td></tr>");
                                sbNote.AppendLine();
                            }

                            if (dr["ReceiveBy"] != DBNull.Value)
                            {
                                string info = Converter.ReplaceWitBreakLineHTML((string)dr["ReceiveBy"]);
                                sbNote.AppendFormat($"<tr><td class='label' valign='top' style='font-weight: bold;width:{collWidth}px; padding-left:2px'>{"Receive By"}:</td><td valign='top'>{info}</td></tr>");
                                sbNote.AppendLine();
                            }
                        }
                        else if (SRMedicalNotesInputType == "ADIME")
                        {
                            if (dr["Info5"] != DBNull.Value)
                            {
                                var info = Converter.ReplaceWitBreakLineHTML((string)dr["Info5"]);
                                sbNote.AppendFormat($"<tr><td class='label' valign='top' style='font-weight: bold;width:{collWidth}px;padding-left:2px'>{"E"}:</td><td valign='top'>{info}</td></tr>");
                                sbNote.AppendLine();
                            }
                        }
                        break;

                    case "REF":
                    case "CON":
                        sbNote.AppendFormat($"<tr><td colspan='2' style='font-weight: bold;padding-left:2px;'>{(SRMedicalNotesInputType == "REF" ? "Refer" : "Consult")} to : {dr["Info1"]}</td></tr>");
                        sbNote.AppendFormat("<tr><td colspan='2' style='padding-left:2px;'>Notes :</td></tr>");
                        sbNote.AppendFormat($"<tr><td width:10px;'>&nbsp;</td><td>{Converter.FormatToHtml(dr["Info2"])}</td></tr>");
                        sbNote.AppendLine();

                        sbNote.AppendFormat("<tr><td colspan='2' style='padding-left:2px;'>Action / Examination / Treatment :</td></tr>");
                        sbNote.AppendFormat($"<tr><td  width:10px;'>&nbsp;</td><td>{Converter.FormatToHtml(dr["Info3"])}</td></tr>");
                        sbNote.AppendLine();

                        var answerMenu = string.Empty;
                        var pcr = _paramedicConsultRefer.LoadByPrimaryKey((string)dr["ReferenceNo"]);
                        if (!string.IsNullOrEmpty(pcr.ConsultReferNo) && pcr.ToParamedicId == parId)
                            answerMenu = $"<a href=\"javascript:void(0);\" onclick=\"javascript:entryParamedicConsultAnswer('{dr["ReferenceNo"]}','{dr["RegistrationNo"]}')\"><i class=\"{BaseIcon.Pensquare}\"></i></a>";

                        sbNote.AppendFormat($"<tr><td colspan='2' style='padding-left:2px;'>{answerMenu}Answer :</td></tr>");
                        sbNote.AppendFormat($"<tr><td width:10px'>&nbsp;</td><td>{Converter.FormatToHtml(pcr.Answer)}</td></tr>");
                        sbNote.AppendLine();
                        break;

                    default:
                        sbNote.AppendFormat($"<tr><td colspan='2' style='padding-left:2px;'>{Converter.FormatToHtml(dr["Info1"])}</td></tr>");
                        if (dr["ReferenceToPhrNo"] != DBNull.Value && !string.IsNullOrEmpty((string)dr["ReferenceToPhrNo"]) && _patientHealthRecord.LoadByTransactionNoRegNoOfTemplateEntry((string)dr["ReferenceToPhrNo"], (string)dr["RegistrationNo"]))
                            dr["Info2"] = dr["Info2"];

                        var info2 = Converter.ReplaceWitBreakLineHTML((string)dr["Info2"]);
                        if (!string.IsNullOrEmpty(info2))
                        {
                            sbNote.AppendFormat($"<tr><td class='label' valign='top' style='font-weight: bold; width:10px;padding-left:2px'>Respond:</td><td valign='top'>{info2}{((string.IsNullOrEmpty((string)dr["TemplateID"]) || (string)dr["TemplateID"] == "0") ? "" : $" <a href=\"javascript:void(0);\" onclick=\"javascript:OpenTableRespond('{(string)dr["TemplateID"]}')\"><i class=\"{BaseIcon.Eye}\"></i></a>")}</td></tr>");
                            sbNote.AppendLine();
                        }
                        break;
                }

                if (dr["AttendingNotes"] != DBNull.Value && !string.IsNullOrEmpty((string)dr["AttendingNotes"]))
                    sbNote.AppendFormat($"<tr><td class='label' valign='top' style='font-weight: bold; width:10px;padding-left:2px'>N:</td><td valign='top'>{dr["AttendingNotes"]}</td></tr>");


                if (dr["DpjpNotes"] != DBNull.Value && !string.IsNullOrWhiteSpace((string)dr["DpjpNotes"]))
                    sbNote.AppendFormat("<tr><td colspan='2' style='horiz-align: right;'>* DPJP Note: {0}</td></tr>", (string)dr["DpjpNotes"]);

                if (dr["ApprovedDateTime"] != DBNull.Value)
                {
                    var label = dr["ParamedicID"] == DBNull.Value ? _appParameter.ParameterString("IntNotesVerifLabelReview") : _appParameter.ParameterString("IntNotesVerifLabel");
                    var approvedDate = $"<i class=\"{BaseIcon.Checksquare}\"></i>&nbsp;{label}: {Convert.ToDateTime(dr["ApprovedDateTime"]).ToString(Const.Datetimesecond)} By: {_paramedic.GetParamedicName((string)dr["ApprovedByUserID"])} ({dr["ApprovedByUserID"]})";
                    sbNote.AppendFormat($"<tr><td colspan='2' style='horiz-align: right;'>{approvedDate}</td></tr>");
                }

                sbNote.AppendLine("</table>");
                dr["Result"] = sbNote.ToString();

                if (dr["ParamedicID"] != DBNull.Value)
                    dr["ParamedicName"] = _paramedic.GetParamedicName((string)dr["ParamedicID"]);

                if (dr["ServiceUnitID"] == DBNull.Value)
                    dr["ServiceUnitID"] = _patientTransferHistory.GetServiceUnitId((string)dr["RegistrationNo"], (DateTime)dr["ExecuteDateTime"]);

                dr["ServiceUnitName"] = _serviceUnit.GetServiceUnitName((string)dr["ServiceUnitID"]);
                dr["CreatedByUserName"] = _appUser.GetUsername((string)dr["CreatedByUserID"]);
                dr["DateTimeInfoStr"] = $"{Convert.ToDateTime(dr["DateTimeInfo"]).ToString(Const.Date)} {Convert.ToDateTime(dr["DateTimeInfo"]).ToString(Const.Hourmin)}";
                dr["AdditionalInfo"] = _patientAssessment.AdditionalNoteScript((string)dr["AssessmentTypeName"], (string)dr["RegistrationInfoMedicID"]);
            }
            #endregion

            return Converter.DataTableToList<RegistrationInfoMedicDto>(dtb);
        }
    }
}
