using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class HisBedBridging
{
    public string BedId { get; set; } = null!;

    public string? BedPrefix { get; set; }

    public string BedCode { get; set; } = null!;

    public int BedNumber { get; set; }

    public string RoomId { get; set; } = null!;

    public int? IsActive { get; set; }

    public string? Optional3 { get; set; }

    public string? InsertedByUserId { get; set; }

    public DateTime? InsertedDate { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public byte[] Qrcode { get; set; } = null!;
}
