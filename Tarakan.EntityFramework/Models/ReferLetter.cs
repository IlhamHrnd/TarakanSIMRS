using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ReferLetter
{
    public string RegApptNo { get; set; }

    public string FromRegistrationNo { get; set; }

    public string ActionExamTreatment { get; set; }

    public string Notes { get; set; }

    public string Answer { get; set; }

    public bool? IsAppointment { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
