using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MembershipMember
{
    public string MembershipNo { get; set; }

    public string PatientId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
