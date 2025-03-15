using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransaksiBku
{
    public string Nomor { get; set; } = null!;

    public byte? Jenis { get; set; }

    public string? Pelanggan { get; set; }

    public string? Unit { get; set; }

    public DateTime? Tanggal { get; set; }

    public string? Uraian { get; set; }

    public string? KasBank { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public virtual ICollection<TransaksiBkuDetail> TransaksiBkuDetails { get; set; } = new List<TransaksiBkuDetail>();
}
