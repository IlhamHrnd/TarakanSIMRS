using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ServiceUnitBookingBodyImage
{
    public string BookingNo { get; set; } = null!;

    public string OpNotesSeqNo { get; set; } = null!;

    public string BodyId { get; set; } = null!;

    public byte[]? BodyImage { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
