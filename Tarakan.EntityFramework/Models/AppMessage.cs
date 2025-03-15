using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppMessage
{
    public string MessageId { get; set; } = null!;

    public string MessageText { get; set; } = null!;

    public string? MessageTextCustom { get; set; }

    public bool? IsError { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
