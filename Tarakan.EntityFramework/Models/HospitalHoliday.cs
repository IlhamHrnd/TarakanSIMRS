using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class HospitalHoliday
{
    public DateTime HospitalHolydayDateTime { get; set; }

    public DateTime? LastCreatedDateTime { get; set; }

    public string? LastCreatedUserId { get; set; }

    public bool? IsRepetitive { get; set; }
}
