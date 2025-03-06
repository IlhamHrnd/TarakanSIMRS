﻿using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PastSurgicalHistory
{
    public string PatientId { get; set; }

    public string SurgicalHistory { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
