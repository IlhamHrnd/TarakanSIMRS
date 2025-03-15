using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppStandardReferenceItem
{
    public string StandardReferenceId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string? ItemName { get; set; }

    public string? Note { get; set; }

    public bool? IsUsedBySystem { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? ReferenceId { get; set; }

    public int? CoaId { get; set; }

    public int? SubledgerId { get; set; }

    public string? CustomField { get; set; }

    public int? LineNumber { get; set; }

    public decimal? NumericValue { get; set; }

    public string? CustomField2 { get; set; }
}
