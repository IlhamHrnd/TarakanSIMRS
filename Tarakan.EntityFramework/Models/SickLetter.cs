﻿using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SickLetter
{
    public string RegistrationNo { get; set; }

    public string ParamedicId { get; set; }

    public string SrletterType { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
