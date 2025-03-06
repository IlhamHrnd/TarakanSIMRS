using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Infection
{
    public string InfectionId { get; set; }

    public string ParentInfectionId { get; set; }

    public string InfectionName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string AbLev1Notes { get; set; }

    public string AbLev2Notes { get; set; }

    public string AbLev3Notes { get; set; }

    public string AbRestrictionType { get; set; }
}
