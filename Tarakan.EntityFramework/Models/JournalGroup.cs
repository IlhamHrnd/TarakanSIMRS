﻿using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class JournalGroup
{
    public int JournalGroupId { get; set; }

    public string JournalGroupName { get; set; }

    public string Notes { get; set; }

    public bool IsActive { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
