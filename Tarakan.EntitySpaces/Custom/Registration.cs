using Tarakan.EntitySpaces.Helper;

namespace Tarakan.EntitySpaces.Generated
{
    public partial class Registration
    {
        [Obsolete]
        public static string[] GetMergeRegistration(string regNo)
        {
            var mb = new MergeBilling();
            mb.LoadByPrimaryKey(regNo);

            var mbColl = new MergeBillingCollection();
            if (!string.IsNullOrEmpty(mb.FromRegistrationNo))
                mbColl.Query.Where(mbColl.Query.Or(mbColl.Query.RegistrationNo == mb.RegistrationNo, mbColl.Query.FromRegistrationNo == mb.RegistrationNo, mbColl.Query.RegistrationNo == mb.FromRegistrationNo,mbColl.Query.FromRegistrationNo == mb.FromRegistrationNo));
            else
                mbColl.Query.Where(mbColl.Query.Or(mbColl.Query.RegistrationNo == mb.RegistrationNo,mbColl.Query.FromRegistrationNo == mb.RegistrationNo));
            mbColl.LoadAll();
            var r = new Registration();
            r.LoadByPrimaryKey(regNo);

            if (r.SRRegistrationType == "IPR")
                return [.. mbColl.Select(m => m.RegistrationNo)];

            var list = string.IsNullOrEmpty(mbColl.SingleOrDefault(m => m.RegistrationNo == regNo).FromRegistrationNo) ?
                mbColl.Select(m => m.RegistrationNo).ToArray() :
                [.. mbColl.Where(m => m.RegistrationNo == regNo).Select(m => m.RegistrationNo)];

            if (list.Length == 0)
            {
                var ap = new AppParameter();
                int max = !ap.LoadByPrimaryKey("MaxResultRecord") ? 500 : Converter.StringToInt(ap.ParameterValue);
                list = new string[max];

                var dColl = new DepartmentCollection();
                dColl.Query.Where(dColl.Query.IsActive == true);
                dColl.LoadAll();
                var idx = 0;

                foreach (var item in dColl.Select(dept => mbColl.Where(m => m.RegistrationNo.IndexOf(dept.Initial) != -1).Select(m => m.RegistrationNo).ToArray()).SelectMany(r => r))
                {
                    list.SetValue(item, idx);
                    idx++;
                }
                return [.. list.Where(l => !string.IsNullOrEmpty(l))];
            }
            return list;
        }

        public static string RegistrationTransferStatus(bool isAlreadyTransfer, string transferNo)
        {
            if (!isAlreadyTransfer && !string.IsNullOrEmpty(transferNo))
            {
                var pt = new PatientTransfer();
                var su = new ServiceUnit();
                var b = new Bed();
                var asri = new AppStandardReferenceItem();

                if (!pt.LoadByPrimaryKey(transferNo))
                    return string.Empty;

                if (!su.LoadByPrimaryKey(pt.ToServiceUnitID))
                    return string.Empty;

                if (!b.LoadByPrimaryKey(pt.ToBedID))
                    return string.Empty;

                string bedStatus = !asri.LoadByPrimaryKey("BedStatus", b.SRBedStatus) ? string.Empty : asri.ItemName;
                string bedImage = bedStatus switch
                {
                    "Pending" => "infored16.png",
                    "Booked" => "infoyellow16.png",
                    _ => string.Empty,
                };
                string title = !string.IsNullOrEmpty(bedImage) ? $"Patient Transfer To {su.ServiceUnitName} Status {bedStatus}" : string.Empty;
                return $"<p class=\"blinking\">{title} <i class=\"fa-solid fa-triangle-exclamation text-danger\"></i></p>";
            }
            else
                return string.Empty;
        }

        [Obsolete]
        public static string SoapEntryStatus(string regNo, string parId, string regType)
        {
            var rimQ = new RegistrationInfoMedicQuery("rQ");

            rimQ.Select(rimQ.RegistrationInfoMedicID)
                .Where(rimQ.RegistrationNo == regNo, rimQ.SRMedicalNotesInputType == "SOAP", rimQ.Info1 != string.Empty, rimQ.Or(rimQ.IsDeleted.IsNull(), rimQ.IsDeleted == false));

            if (regType == "IPR")
                rimQ.Where(rimQ.ParamedicID == parId, rimQ.DateTimeInfo > DateTime.Now);

            return rimQ.LoadDataTable().Rows.Count > 0 ? $"<i class=\"fa-solid fa-bell text-success\" alt=\"SOAP Inputted\" title=\"SOAP Inputted\"></i>" : string.Empty;
        }
    }
}
