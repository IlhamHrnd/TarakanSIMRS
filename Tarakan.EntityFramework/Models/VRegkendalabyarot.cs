using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VRegkendalabyarot
{
    public string RegistrationNo { get; set; } = null!;

    public string PatientId { get; set; } = null!;

    public string? ServiceUnitId { get; set; }

    public string? ParamedicId { get; set; }

    public string GuarantorId { get; set; } = null!;

    public DateTime? DischargeDate { get; set; }

    public decimal? AdministrationAmount { get; set; }

    public decimal? DiscAdmPatient { get; set; }

    public decimal? DiscAdmGuarantor { get; set; }

    public string SrguarantorType { get; set; } = null!;

    public DateTime RegistrationDate { get; set; }

    public string? Information { get; set; }
}
