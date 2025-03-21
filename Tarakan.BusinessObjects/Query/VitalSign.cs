﻿using System.Data;
using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Helper;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class VitalSign : BaseQuery, IVitalSign
    {
        public VitalSign(AppDbContext context) : base(context)
        {
            
        }

        [Obsolete]
        public DateTime LastVitalSignDate(string registrationNo, string fromRegistrationNo)
        {
            var phrlQ = new EntitySpaces.Generated.PatientHealthRecordLineQuery("phrlQ");
            var qQ = new EntitySpaces.Generated.QuestionQuery("qQ");
            var vsQ = new EntitySpaces.Generated.VitalSignQuery("vsQ");
            var phrQ = new EntitySpaces.Generated.PatientHealthRecordQuery("phrQ");

            phrlQ.InnerJoin(qQ).On(qQ.QuestionID == phrlQ.QuestionID)
                .InnerJoin(vsQ).On(vsQ.VitalSignID == qQ.VitalSignID)
                .InnerJoin(phrQ).On(phrQ.TransactionNo == phrlQ.TransactionNo && phrQ.RegistrationNo == phrlQ.RegistrationNo);

            if (!string.IsNullOrEmpty(fromRegistrationNo))
                phrlQ.Where(phrlQ.Or(phrlQ.RegistrationNo == registrationNo, phrlQ.RegistrationNo == fromRegistrationNo));
            else
                phrlQ.Where(phrlQ.RegistrationNo == registrationNo);

            phrlQ.Select(phrQ.RecordDate)
                .Where(phrlQ.QuestionAnswerNum > 0)
                .OrderBy(phrQ.RecordDate.Descending)
                .Top(1);

            var dt = phrlQ.LoadDataTable();
            var lastVitalSignDate = new DateTime(1900, 1, 1);

            foreach (DataRow dr in dt.Rows)
            {
                lastVitalSignDate = Convert.ToDateTime(dr["RecordDate"]);
            }
            return lastVitalSignDate;
        }

        [Obsolete]
        public List<VitalSignDto> VitalSignLastValue(string registrationNo, string fromRegistrationNo, bool isWithEwsLevel, DateTime lastDateTime)
        {
            var dt = EntitySpaces.Generated.VitalSign.VitalSignLastValue(registrationNo, fromRegistrationNo, isWithEwsLevel, lastDateTime);
            if (dt.Rows.Count == 0)
                return [];
            else
                return Converter.DataTableToList<VitalSignDto>(dt);
        }
    }
}
