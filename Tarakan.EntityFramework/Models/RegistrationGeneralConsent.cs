using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationGeneralConsent
{
    public string RegistrationNo { get; set; } = null!;

    public string? NameOfConsentee { get; set; }

    public string? Srrelationship { get; set; }

    public string? ConsenteeSsn { get; set; }

    public string? NameOfWitness { get; set; }

    public string? WitnessSsn { get; set; }

    public string? NameOfOfficer { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public byte[]? PatientSign { get; set; }

    public byte[]? WitnessSign { get; set; }

    public byte[]? OfficerSign { get; set; }
}
