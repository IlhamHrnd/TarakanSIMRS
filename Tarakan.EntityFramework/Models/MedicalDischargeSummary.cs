using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MedicalDischargeSummary
{
    public string RegistrationNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string ChiefComplaint { get; set; }

    public string HistOfPresentIllness { get; set; }

    public string Komorbiditas { get; set; }

    public string PhysicalExam { get; set; }

    public string AncillaryExam { get; set; }

    public string MedicalProcedures { get; set; }

    public string ProcedureId { get; set; }

    public string Medications { get; set; }

    public string AdmittingDiagnoseId1 { get; set; }

    public string AdmittingDiagnoseName1 { get; set; }

    public string AdmittingDiagnoseId2 { get; set; }

    public string AdmittingDiagnoseName2 { get; set; }

    public string FinalDiagnoseId1 { get; set; }

    public string FinalDiagnoseName1 { get; set; }

    public string FinalDiagnoseId2 { get; set; }

    public string FinalDiagnoseName2 { get; set; }

    public string FinalDiagnoseId3 { get; set; }

    public string FinalDiagnoseName3 { get; set; }

    public string PresentStatus { get; set; }

    public string SuggestionFollowUp { get; set; }

    public string TreatmentIndications { get; set; }

    public string PastMedicalHistory { get; set; }

    public string ProcedureName { get; set; }

    public DateTime? DischargeDate { get; set; }

    public string DischargeTime { get; set; }

    public string ParamedicId { get; set; }

    public string ParamedicName { get; set; }

    public string SrunitIntended { get; set; }

    public string SrdischargeMethod { get; set; }

    public string SrdischargeCondition { get; set; }

    public string Prognosis { get; set; }

    public bool? IsRichTextMode { get; set; }

    public string AncillaryExamOther { get; set; }

    public string Diet { get; set; }

    public DateTime? DocumentDate { get; set; }

    public byte[] PpaSign { get; set; }
}
