using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Membership
{
    public string MembershipNo { get; set; }

    public string SrmembershipType { get; set; }

    public DateTime JoinDate { get; set; }

    public string PatientId { get; set; }

    public int? PersonId { get; set; }

    public string MemberName { get; set; }

    public string Srsalutation { get; set; }

    public string Sex { get; set; }

    public string CityOfBirth { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string Address { get; set; }

    public string PhoneNo { get; set; }

    public string MobilePhoneNo { get; set; }

    public string Email { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? ValidTo { get; set; }
}
