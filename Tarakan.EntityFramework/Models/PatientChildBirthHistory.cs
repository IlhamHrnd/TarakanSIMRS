using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientChildBirthHistory
{
    public string PatientId { get; set; }

    public int SequenceNo { get; set; }

    public string ChildBirth { get; set; }

    public string Sex { get; set; }

    public string Helper { get; set; }

    public string Location { get; set; }

    public string Hm { get; set; }

    public string Bbl { get; set; }

    public string Complication { get; set; }

    public string Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public int? PregnanDurationMonth { get; set; }

    public int? PregnanDurationWeek { get; set; }

    public string SrbirthMethod { get; set; }
}
