using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class PatientHealthRecord : BaseQuery, IPatientHealthRecord
    {
        public PatientHealthRecord(AppDbContext context) : base(context)
        {
            
        }

        public bool LoadByTransactionNoRegNoOfTemplateEntry(string transNo, string regNo)
        {
            var phrlQ = new EntitySpaces.Generated.PatientHealthRecordLineQuery("phrlQ");
            var ndtdQ = new EntitySpaces.Generated.NursingDiagnosaTemplateDetailQuery("ndtdQ");
            phrlQ.LeftJoin(ndtdQ).On(phrlQ.QuestionFormID == ndtdQ.TemplateID && phrlQ.QuestionID == ndtdQ.QuestionID)
                .Where(phrlQ.TransactionNo == transNo, phrlQ.RegistrationNo == regNo)
                .OrderBy(ndtdQ.RowIndex.Ascending);
            return phrlQ.LoadDataTable().Rows.Count > 0;
        }
    }
}
