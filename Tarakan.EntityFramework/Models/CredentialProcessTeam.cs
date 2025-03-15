using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CredentialProcessTeam
{
    public string TransactionNo { get; set; } = null!;

    public int PersonId { get; set; }

    public int PositionId { get; set; }

    public string SrcredentialingTeamPosition { get; set; } = null!;

    public string AreasOfExpertise { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
