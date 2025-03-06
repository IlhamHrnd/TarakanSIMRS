using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ApplicantWorkExperience
{
    public int ApplicantWorkExperienceId { get; set; }

    public int ApplicantId { get; set; }

    public string SrlineBisnis { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string Company { get; set; }

    public string Division { get; set; }

    public string Location { get; set; }

    public string JobDesc { get; set; }

    public string SupervisorName { get; set; }

    public decimal? LastSalary { get; set; }

    public string ReasonOfLeaving { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
