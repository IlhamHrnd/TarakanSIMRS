using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CssdSterileItemsReturned
{
    public string ReturnNo { get; set; }

    public DateTime ReturnDate { get; set; }

    public string ReturnTime { get; set; }

    public string ToServiceUnitId { get; set; }

    public string HandedByUserId { get; set; }

    public string ReceivedBy { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string VoidByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsClosed { get; set; }

    public string ClosedByUserId { get; set; }

    public DateTime? ClosedDateTime { get; set; }
}
