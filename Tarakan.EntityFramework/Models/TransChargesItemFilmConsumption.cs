using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransChargesItemFilmConsumption
{
    public string TransactionNo { get; set; }

    public string SequenceNo { get; set; }

    public string SrfilmId { get; set; }

    public decimal Qty { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public decimal? Kv { get; set; }

    public decimal? Ma { get; set; }

    public decimal? S { get; set; }

    public decimal? Mas { get; set; }

    public decimal? KvC { get; set; }

    public decimal? MaC { get; set; }

    public decimal? SC { get; set; }

    public decimal? MasC { get; set; }

    public decimal? Ffd { get; set; }

    public decimal? ScreeningTime { get; set; }

    public decimal? CineTime { get; set; }

    public string Notes { get; set; }
}
