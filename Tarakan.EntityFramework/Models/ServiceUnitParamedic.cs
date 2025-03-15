using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ServiceUnitParamedic
{
    public string ServiceUnitId { get; set; } = null!;

    public string ParamedicId { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? DefaultRoomId { get; set; }

    public bool? IsUsingQue { get; set; }

    public bool? IsAcceptBpjs { get; set; }

    public bool? IsActive { get; set; }
}
