using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientMembership
{
    public string MembershipNo { get; set; } = null!;

    public DateTime JoinDate { get; set; }

    public string PatientId { get; set; } = null!;

    public string SrmembershipType { get; set; } = null!;

    public bool? IsActive { get; set; }

    public DateTime? LastCreateDateTime { get; set; }

    public string? LastCreateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
