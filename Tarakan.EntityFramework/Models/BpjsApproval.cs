using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BpjsApproval
{
    public string NoKartu { get; set; } = null!;

    public DateTime TglSep { get; set; }

    public string JnsPelayanan { get; set; } = null!;

    public string? NamaPasien { get; set; }

    public string? JenisKelamin { get; set; }

    public string? Keterangan { get; set; }

    public bool? IsApproved { get; set; }

    public string? User { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? JnsPengajuan { get; set; }
}
