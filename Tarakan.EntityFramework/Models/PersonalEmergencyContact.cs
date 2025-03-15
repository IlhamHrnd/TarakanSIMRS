using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PersonalEmergencyContact
{
    public int PersonalEmergencyContactId { get; set; }

    public int PersonId { get; set; }

    public string ContactName { get; set; } = null!;

    public string? Address { get; set; }

    public string? Srstate { get; set; }

    public string? Srcity { get; set; }

    public string? ZipCode { get; set; }

    public string? Phone { get; set; }

    public string? Mobile { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public string? District { get; set; }

    public string? County { get; set; }

    public string? City { get; set; }

    public string? SrfamilyRelation { get; set; }
}
