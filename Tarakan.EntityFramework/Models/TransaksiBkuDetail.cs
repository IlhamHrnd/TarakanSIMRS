using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransaksiBkuDetail
{
    public int Id { get; set; }

    public string? Nomor { get; set; }

    public int? KodeRekening { get; set; }

    public string? KodeItem { get; set; }

    public string? Memo { get; set; }

    public decimal? Nominal { get; set; }

    public string? Posisi { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public virtual TransaksiBku? NomorNavigation { get; set; }
}
