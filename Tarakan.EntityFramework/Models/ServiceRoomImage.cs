using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ServiceRoomImage
{
    public string RoomId { get; set; } = null!;

    public int SeqNo { get; set; }

    public int? IndexNo { get; set; }

    public byte[]? Photo { get; set; }
}
