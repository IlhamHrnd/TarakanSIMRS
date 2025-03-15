using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TerdugaTb
{
    public string No { get; set; } = null!;

    public string? NoIdentitasSediaan { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public string? MedicalNo { get; set; }

    public string? Ssn { get; set; }

    public string? Barcode { get; set; }

    public string? PatientName { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? Umur { get; set; }

    public string? Sex { get; set; }

    public string? Address { get; set; }

    public string? DirujukOleh { get; set; }

    public string? FasyankesRujukan { get; set; }

    public string? KriteriaTerdugaTb { get; set; }

    public string? RiwayatDm { get; set; }

    public string? StatusHiv { get; set; }

    public DateTime? TanggalHasilDiagnosis { get; set; }

    public string? HasilDiagnosis { get; set; }

    public string? TindakLanjut { get; set; }

    public string? TempatPengobatan { get; set; }

    public string? Keterangan { get; set; }

    public string? StatusDiagnosis { get; set; }

    public string? Warning { get; set; }
}
