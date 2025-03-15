using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class RegistrationPathway : BaseQuery, IRegistrationPathway
    {
        public RegistrationPathway(AppDbContext context) : base(context)
        {
            
        }

        public string GetRegistrationPathwayName(string regNo)
        {
            var rpQ = new EntitySpaces.Generated.RegistrationPathwayQuery("rpQ");
            var pQ = new EntitySpaces.Generated.PathwayQuery("pQ");
            rpQ.Select(pQ.PathwayID, pQ.PathwayName, rpQ.PathwayStatus)
                .InnerJoin(pQ).On(pQ.PathwayID == rpQ.PathwayID)
                .Where(rpQ.RegistrationNo == regNo, rpQ.PathwayID != string.Empty)
                .Top(1);
            var dt = rpQ.LoadDataTable();
            return dt.Rows.Count > 0
                ? $"{dt.Rows[0]["PathwayName"]} ({(dt.Rows[0]["PathwayStatus"].ToString() == "A" ? "ACCEPT" : (dt.Rows[0]["PathwayStatus"].ToString() == "F" ? "FAIL" : "-"))})"
                : "-";
        }
    }
}
