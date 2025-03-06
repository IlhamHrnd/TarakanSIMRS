using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientMembership
{
    public string MembershipNo { get; set; }

    public DateTime JoinDate { get; set; }

    public string PatientId { get; set; }

    public string SrmembershipType { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? LastCreateDateTime { get; set; }

    public string LastCreateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
