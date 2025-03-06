using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientInfo
{
    public string PatientInfoId { get; set; }

    public string PatientId { get; set; }

    public string Information { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public virtual Patient Patient { get; set; }
}
