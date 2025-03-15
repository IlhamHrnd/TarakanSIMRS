using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class WhatsappMessage
{
    public string WhatsappMessageId { get; set; } = null!;

    public string? Type { get; set; }

    public string? RoomId { get; set; }

    public bool? IsCampaign { get; set; }

    public string? SenderId { get; set; }

    public string? SenderType { get; set; }

    public string? SenderName { get; set; }

    public string? Text { get; set; }
}
