using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BloodExtermination
{
    public string TransactionNo { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public string SrreasonsForExtermination { get; set; } = null!;

    public decimal Weight { get; set; }

    public string BloodBankOfficerByUserId { get; set; } = null!;

    public string IncineratorOperator { get; set; } = null!;

    public string KnownBy { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
