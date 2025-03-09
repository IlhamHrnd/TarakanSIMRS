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
            var mbQ = new MergeBillingQuery("mbQ");
            if (!string.IsNullOrEmpty(mb.FromRegistrationNo))
                mbQ.Select(mbQ.RegistrationNo)
                    .Where(mbQ.Or(mbQ.RegistrationNo == mb.RegistrationNo, mbQ.FromRegistrationNo == mb.RegistrationNo, mbQ.RegistrationNo == mb.FromRegistrationNo, mbQ.FromRegistrationNo == mb.FromRegistrationNo));
            else
                mbQ.Select(mbQ.RegistrationNo)
                    .Where(mbQ.Or(mbQ.RegistrationNo == mb.RegistrationNo, mbQ.FromRegistrationNo == mb.RegistrationNo));
            mbColl.Load(mbQ);

            var r = new Registration();
            r.LoadByPrimaryKey(regNo);

            if (r.SRRegistrationType == "IPR")
                return [.. mbColl.Select(m => m.RegistrationNo)];

            var list = string.IsNullOrEmpty(mbColl.SingleOrDefault(m => m.RegistrationNo == regNo).FromRegistrationNo) ?
                        [.. mbColl.Select(m => m.RegistrationNo)] :
                        mbColl.Where(m => m.RegistrationNo == regNo).Select(m => m.RegistrationNo).ToArray();

            if (list.Length == 0)
            {
                var ap = new AppParameter();
                int max = !ap.LoadByPrimaryKey("MaxResultRecord") ? 0 : Converter.StringToInt(ap.ParameterValue);
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
    }
}
