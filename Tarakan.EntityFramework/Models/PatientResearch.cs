using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientResearch
{
    public int ResearchId { get; set; }

    public string PatientId { get; set; }

    public string ResearchTitle { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string ParamedicId { get; set; }

    public string Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
