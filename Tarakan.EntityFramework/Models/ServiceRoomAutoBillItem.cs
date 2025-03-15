using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ServiceRoomAutoBillItem
{
    public string RoomId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public decimal Quantity { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
