using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Raspro
{
    public string RasproLineId { get; set; } = null!;

    public string Srraspro { get; set; } = null!;

    public int SeqNo { get; set; }

    public string Spesification { get; set; } = null!;

    public string? YesAction { get; set; }

    public bool? IsYesContinue { get; set; }

    public string? YesActionDescription { get; set; }

    public string? NoAction { get; set; }

    public bool? IsNoContinue { get; set; }

    public string? NoActionDescription { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? CreateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
