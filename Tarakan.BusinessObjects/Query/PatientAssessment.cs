﻿using Tarakan.BusinessObjects.Dto;
using Tarakan.BusinessObjects.Interface;
using Tarakan.EntityFramework.Base;

namespace Tarakan.BusinessObjects.Query
{
    public class PatientAssessment : BaseQuery, IPatientAssessment
    {
        public PatientAssessment(AppDbContext context) : base(context)
        {

        }

        public string AdditionalNoteScript(string assessmentName, string regInfoMedicId)
        {
            if (string.IsNullOrEmpty(assessmentName) || string.IsNullOrEmpty(regInfoMedicId))
                return string.Empty;

            var query = _context.PatientAssessments
                .Where(pa => pa.RegistrationInfoMedicId == regInfoMedicId)
                .Select(pa => new PatientAssessmentDto
                {
                    AdditionalNotes = pa.AdditionalNotes ?? string.Empty
                }).ToList();

            if (query.Count == 0)
                return string.Empty;

            var item = query.First();
            if (string.IsNullOrEmpty(item.AdditionalNotes))
                return string.Empty;

            return $"<br /><fieldset><legend>Additional Notes</legend>{item.AdditionalNotes}</fieldset>";
        }
    }
}
