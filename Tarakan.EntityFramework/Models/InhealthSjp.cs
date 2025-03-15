using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class InhealthSjp
{
    public string Nosjp { get; set; } = null!;

    public string Nokainhealth { get; set; } = null!;

    public DateTime Tanggalpelayanan { get; set; }

    public DateTime? Tanggalasalrujukan { get; set; }

    public string? Nomorasalrujukan { get; set; }

    public string? Kodeproviderasalrujukan { get; set; }

    public string? NamaProviderAsalRujukan { get; set; }

    public string Kodeprovider { get; set; } = null!;

    public string Jenispelayanan { get; set; } = null!;

    public string? Informasitambahan { get; set; }

    public string? Kodediagnosautama { get; set; }

    public string? Kodediagnosatambahan { get; set; }

    public string Poli { get; set; } = null!;

    public string Kelasrawat { get; set; } = null!;

    public int Kecelakaankerja { get; set; }

    public string Username { get; set; } = null!;

    public string? Nomormedicalreport { get; set; }

    public DateTime? TanggalPulang { get; set; }

    public string? NoTransaksi { get; set; }

    public string? DetailKeanggotaan { get; set; }

    public string? PatientId { get; set; }

    public string? Kodejenpelruangrawat { get; set; }

    public string NamaPasien { get; set; } = null!;

    public DateTime TanggalLahir { get; set; }
}
