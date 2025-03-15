using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwPrescriptionSale
{
    public string? RegistrationNo { get; set; }

    public string? PatientId { get; set; }

    public DateTime? ApprovalDateTime { get; set; }

    public string? PatientName { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string? MedicalNo { get; set; }

    public string OldMedicalNo { get; set; } = null!;

    public string? SritemUnit { get; set; }

    public decimal PrescriptionQty { get; set; }

    public byte? Fod { get; set; }

    public string? Dp { get; set; }

    public decimal? Nod { get; set; }

    public string? Unit { get; set; }

    public string? CodeLabel { get; set; }

    public string? Label { get; set; }

    public string? Acpcdc { get; set; }

    public string? Notes { get; set; }

    public string? ItemName { get; set; }

    public string? NamaJumlah { get; set; }

    public string? NamaJumlahQty { get; set; }

    public string? ParamedicName { get; set; }

    public byte AgeInYear { get; set; }

    public string Jumlah { get; set; } = null!;

    public decimal? Price { get; set; }

    public string IsRflag { get; set; } = null!;

    public string PrescriptionNo { get; set; } = null!;

    public string? Nomor { get; set; }

    public string? ConsumeMethod { get; set; }

    public string? Metod { get; set; }

    public string? Apc { get; set; }
}
