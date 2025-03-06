using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemTariffRequestProcess
{
    public string TariffRequestNo { get; set; }

    public DateTime TariffRequestDate { get; set; }

    public string SritemType { get; set; }

    public string FromSrtariffType { get; set; }

    public string ToSrtariffType { get; set; }

    public DateTime StartingDate { get; set; }

    public string Notes { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDate { get; set; }

    public string VoidByUserId { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string ApprovedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string ItemGroupId { get; set; }

    public decimal? RoundingValue { get; set; }

    public bool? IsRoundingDown { get; set; }

    public DateTime? FromDate { get; set; }
}
