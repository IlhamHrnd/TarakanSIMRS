﻿using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ApdSurveyItem
{
    public string TransactionNo { get; set; }

    public string SrapdType { get; set; }

    public bool IsCorrectIndication { get; set; }

    public bool IsCorrectUsageTime { get; set; }

    public bool IsCorrectUsageTechnique { get; set; }

    public bool IsCorrectReleaseTechnique { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
