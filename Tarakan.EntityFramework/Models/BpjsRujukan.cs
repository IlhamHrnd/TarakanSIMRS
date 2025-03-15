using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BpjsRujukan
{
    public string NoSep { get; set; } = null!;

    public string NoRujukan { get; set; } = null!;

    public DateTime? TglRujukan { get; set; }

    public string? PpkDirujuk { get; set; }

    public string? NamaPpkDirujuk { get; set; }

    public string? JnsPelayanan { get; set; }

    public string? Catatan { get; set; }

    public string? DiagRujukan { get; set; }

    public string? TipeRujukan { get; set; }

    public string? PoliRujukan { get; set; }

    public string? NamaPoliRujukan { get; set; }

    public string? User { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? TglRencana { get; set; }
}
