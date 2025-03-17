using Tarakan.BusinessObjects.Helper;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;
using Cast = EntitySpaces.DynamicQuery;

namespace Tarakan.BusinessObjects.Query
{
    public class PatientTransferHistory : BaseQuery, IPatientTransferHistory
    {
        public PatientTransferHistory(AppDbContext context) : base(context)
        {
            
        }

        public string? GetServiceUnitId(string regNo, DateTime dateTime)
        {
            var pthQ = new EntitySpaces.Generated.PatientTransferHistoryQuery("pthQ");
            pthQ.Select(pthQ.ServiceUnitID)
                .Where(pthQ.RegistrationNo == regNo, pthQ.DateOfEntry.Cast(Cast.esCastType.DateTime) + pthQ.TimeOfEntry.Cast(Cast.esCastType.DateTime) <= dateTime)
                .OrderBy(pthQ.DateOfEntry.Descending, pthQ.TimeOfEntry.Descending);
            var dt = pthQ.LoadDataTable();
            return dt.Rows.Count > 0 ? dt.Rows[0][0].ToString() : string.Empty;
        }
    }
}
