using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ServiceRoomAutoBillItem
{
    public string RoomId { get; set; }

    public string ItemId { get; set; }

    public decimal Quantity { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
