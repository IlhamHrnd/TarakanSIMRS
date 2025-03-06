using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmergencyContact
{
    public string RegistrationNo { get; set; }

    public string ContactName { get; set; }

    public string Srrelationship { get; set; }

    public string StreetName { get; set; }

    public string District { get; set; }

    public string City { get; set; }

    public string County { get; set; }

    public string State { get; set; }

    public string ZipCode { get; set; }

    public string FaxNo { get; set; }

    public string Email { get; set; }

    public string PhoneNo { get; set; }

    public string MobilePhoneNo { get; set; }

    public string Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string Sroccupation { get; set; }

    public string Ssn { get; set; }

    public virtual Registration RegistrationNoNavigation { get; set; }
}
