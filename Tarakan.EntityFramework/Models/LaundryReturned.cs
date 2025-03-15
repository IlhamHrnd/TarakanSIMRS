using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class LaundryReturned
{
    public string ReturnNo { get; set; } = null!;

    public DateTime ReturnDate { get; set; }

    public string ReturnTime { get; set; } = null!;

    public string ToServiceUnitId { get; set; } = null!;

    public string HandedByUserId { get; set; } = null!;

    public string ReceivedBy { get; set; } = null!;

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
