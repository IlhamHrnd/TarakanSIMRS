using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RlTxReport12
{
    public string RlTxReportNo { get; set; }

    public decimal? Bor { get; set; }

    public decimal? Los { get; set; }

    public decimal? Bto { get; set; }

    public decimal? Toi { get; set; }

    public decimal? Ndr { get; set; }

    public decimal? Gdr { get; set; }

    public decimal? RataKunjungan { get; set; }

    public decimal? RataRata { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
