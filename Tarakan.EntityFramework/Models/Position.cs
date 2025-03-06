﻿using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Position
{
    public int PositionId { get; set; }

    public string PositionCode { get; set; }

    public string PositionName { get; set; }

    public string Summary { get; set; }

    public int? PositionGradeId { get; set; }

    public int? PositionLevelId { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string GeneralQualification { get; set; }
}
