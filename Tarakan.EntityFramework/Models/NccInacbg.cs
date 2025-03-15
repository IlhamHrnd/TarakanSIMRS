using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NccInacbg
{
    public string RegistrationNo { get; set; } = null!;

    public int? PatientId { get; set; }

    public int? AdmissionId { get; set; }

    public int? HospitalAdmissionId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public decimal? AddPaymentAmt { get; set; }

    public decimal? CoverageAmount { get; set; }

    public string? SpecialDrugId { get; set; }

    public decimal? SpecialDrugAmount { get; set; }

    public string? SpecialProcedureId { get; set; }

    public decimal? SpecialProcedureAmount { get; set; }

    public string? CbgId { get; set; }

    public string? CbgName { get; set; }

    public string? CbgStatus { get; set; }

    public string? CbgSentStatus { get; set; }

    public string? SpecialInvestigationId { get; set; }

    public decimal? SpecialInvestigationAmount { get; set; }

    public string? SpecialProsthesisId { get; set; }

    public decimal? SpecialProsthesisAmount { get; set; }
}
