using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpParamedicFee
{
    public double? No { get; set; }

    public string? NoTransaksi { get; set; }

    public string? NamaPasien { get; set; }

    public string? NoRm { get; set; }

    public string? NamaPemeriksaan { get; set; }

    public decimal? Qty { get; set; }

    public string? DokterYangMenjawab { get; set; }

    public string? Penjamin { get; set; }

    public DateTime? TglPeriksa { get; set; }

    public DateTime? TglRealisasi { get; set; }

    public DateTime? TglHasilTest { get; set; }

    public double? Notes { get; set; }
}
