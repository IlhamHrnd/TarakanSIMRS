using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientRelated
{
    public string PatientId { get; set; }

    public string RelatedPatientId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
