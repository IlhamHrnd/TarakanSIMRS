using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeOrientation
{
    public int EmployeeOrientationId { get; set; }

    public int PersonId { get; set; }

    public bool IsGeneral { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public decimal? DurationHour { get; set; }

    public decimal? DurationMinutes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
