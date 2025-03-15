using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TranspaymentUpdate
{
    public double? No { get; set; }

    public string? NoRegistrasi { get; set; }

    public string? NoRm { get; set; }

    public string? NamaPasien { get; set; }

    public string? NamaDokter { get; set; }

    public string? NoPayment { get; set; }

    public string? Sep { get; set; }

    public decimal? TotalPasien { get; set; }

    public decimal? TotalPenjaminBayar { get; set; }

    public decimal? UangMuka { get; set; }

    public decimal? TotalPembayaran { get; set; }

    public decimal? TotalOutstanding { get; set; }

    public string? Closed { get; set; }

    public string? F14 { get; set; }
}
