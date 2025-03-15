using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BpjsRujukanCodeBlue
{
    public Guid Id { get; set; }

    public string ProviderPerujukId { get; set; } = null!;

    public string ProviderPerujukName { get; set; } = null!;

    public string? NoBpjsPeserta { get; set; }

    public string? NoRujukanPeserta { get; set; }

    public string? KodePoli { get; set; }

    public string? NamaPoli { get; set; }

    public string? KodeDokter { get; set; }

    public string? NamaDokter { get; set; }

    public string? CodeBlueNote { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsProcessed { get; set; }

    public DateTime? EntriDate { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? CreateUserId { get; set; }

    public DateTime? UpdateDateTime { get; set; }

    public string? UpdateUserId { get; set; }
}
