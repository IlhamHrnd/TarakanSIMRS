using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ServiceUnitBookingOperatingNote
{
    public string BookingNo { get; set; } = null!;

    public string OpNotesSeqNo { get; set; } = null!;

    public string ParamedicId { get; set; } = null!;

    public string? Regio { get; set; }

    public string? OperatingNotes { get; set; }

    public byte[]? LocalistStatus { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? PostSurgeryInstructions { get; set; }

    public byte[]? SurgeonSign { get; set; }
}
