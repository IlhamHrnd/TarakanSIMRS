using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicTeam
{
    public string RegistrationNo { get; set; } = null!;

    public string ParamedicId { get; set; } = null!;

    public string SrparamedicTeamStatus { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? SourceType { get; set; }
}
