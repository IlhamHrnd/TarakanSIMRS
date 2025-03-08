using System.Data;
using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Filter;
using Tarakan.BusinessObjects.Helper;
using Tarakan.BusinessObjects.Interface;

namespace Tarakan.BusinessObjects.Query
{
    public class Registration
    {
        private readonly IAppParameter _appParameter;

        public Registration(IAppParameter appParameter)
        {
            _appParameter = appParameter;
        }

        [Obsolete]
        public List<RegistrationDto> RegistrationEmr(RegistrationFilter filter, string userId)
        {
            #region Variabel
            var result = new List<RegistrationDto>();
            DataTable dtb = null;
            string[] patientIdSearchs = null;
            string regType = string.Empty;
            bool isShowJobOrder = true;
            bool isShowOperatingRoom = true;
            var size = _appParameter.ParameterInteger("MaxResultRecordEMR");
            var isShowBedStatusPending = _appParameter.ParameterBoolean("IsShowBedStatusPending");
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
                    if (patientIdSearchs == null)
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
                if (patientIdSearchs == null)
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

            }

            return result;
        }
    }
}
