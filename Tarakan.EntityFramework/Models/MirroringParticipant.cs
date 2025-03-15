using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MirroringParticipant
{
    public int DatabaseId { get; set; }

    public Guid MirroringGuid { get; set; }

    public byte? Role { get; set; }

    public string? PrincipalAddress { get; set; }

    public string? MirrorAddress { get; set; }

    public string? WitnessAddress { get; set; }

    public int? SafetyLevel { get; set; }

    public bool? IsSuspended { get; set; }

    public byte? MirroringState { get; set; }

    public byte? WitnessStatus { get; set; }

    public int? MirrorInstanceId { get; set; }

    public int? PrincipalInstanceId { get; set; }

    public string? PartnerInstance { get; set; }

    public DateTime? LastUpdated { get; set; }

    public virtual SqlserverDatabaseName Database { get; set; } = null!;
}
