using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemTariffRequest2
{
    public string TariffRequestNo { get; set; } = null!;

    public DateTime TariffRequestDate { get; set; }

    public string SrtariffType { get; set; } = null!;

    public string? SritemType { get; set; }

    public DateTime StartingDate { get; set; }

    public string? Notes { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDate { get; set; }

    public string? VoidByUserId { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? ApprovedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public bool? IsImport { get; set; }

    public string? ItemGroupId { get; set; }

    public DateTime? ImportFromDate { get; set; }

    public bool? IsNew { get; set; }
}
