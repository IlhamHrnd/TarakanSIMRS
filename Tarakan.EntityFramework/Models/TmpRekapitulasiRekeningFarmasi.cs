using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpRekapitulasiRekeningFarmasi
{
    public DateTime? PrescriptionDate { get; set; }

    public string? RegistrationNo { get; set; }

    public string? PatientId { get; set; }

    public string? PrescriptionNo { get; set; }

    public decimal? Potongan { get; set; }

    public decimal? Jual { get; set; }

    public string? ServiceUnitId { get; set; }

    public string? Shift { get; set; }

    public string? Penjamin { get; set; }

    public string? GroupType { get; set; }

    public string? GuarantorType { get; set; }

    public string? GuarantorName { get; set; }

    public decimal? Pa { get; set; }

    public decimal? Ga { get; set; }

    public string? Username { get; set; }

    public string? Batal { get; set; }

    public string? Aproval { get; set; }

    public string? UserId { get; set; }

    public DateTime? Stime { get; set; }
}
