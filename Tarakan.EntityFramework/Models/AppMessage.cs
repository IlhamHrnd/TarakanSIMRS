using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppMessage
{
    public string MessageId { get; set; }

    public string MessageText { get; set; }

    public string MessageTextCustom { get; set; }

    public bool? IsError { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
