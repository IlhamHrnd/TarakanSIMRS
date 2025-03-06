using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicBridging
{
    public string ParamedicId { get; set; }

    public string SrbridgingType { get; set; }

    public string BridgingId { get; set; }

    public string BridgingName { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string SpecialisticId { get; set; }

    public string DutyType { get; set; }
}
