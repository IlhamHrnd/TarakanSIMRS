﻿using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class Diagnose : BaseQuery, IDiagnose
    {
        public Diagnose(AppDbContext context) : base(context)
        {

        }

        public DiagnoseDto LoadByPrimarykey(string diagId)
        {
            if (string.IsNullOrWhiteSpace(diagId))
                return new DiagnoseDto();

            var query = from d in _context.Diagnoses
                        where d.DiagnoseId == diagId
                        select d;

            if (!query.Any())
                return new DiagnoseDto();

            var diag = new DiagnoseDto();
            foreach (var item in query)
            {
                diag = new DiagnoseDto
                {
                    DiagnoseId = item.DiagnoseId,
                    DtdNo = item.DtdNo ?? string.Empty,
                    DiagnoseName = item.DiagnoseName,
                    IsChronicDisease = item.IsChronicDisease,
                    IsDisease = item.IsDisease,
                    IsActive = item.IsActive
                };
            }
            return diag;
        }
    }
}
