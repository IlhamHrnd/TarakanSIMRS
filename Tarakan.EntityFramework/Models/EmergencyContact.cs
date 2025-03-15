using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmergencyContact
{
    public string RegistrationNo { get; set; } = null!;

    public string ContactName { get; set; } = null!;

    public string Srrelationship { get; set; } = null!;

    public string StreetName { get; set; } = null!;

    public string District { get; set; } = null!;

    public string City { get; set; } = null!;

    public string County { get; set; } = null!;

    public string State { get; set; } = null!;

    public string? ZipCode { get; set; }

    public string FaxNo { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? PhoneNo { get; set; }

    public string? MobilePhoneNo { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? Sroccupation { get; set; }

    public string? Ssn { get; set; }

    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
