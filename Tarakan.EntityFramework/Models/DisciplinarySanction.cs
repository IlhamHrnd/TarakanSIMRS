using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DisciplinarySanction
{
    public int DisciplinarySanctionsId { get; set; }

    public string? SremploymentType { get; set; }

    public short? StartValue { get; set; }

    public short? EndValue { get; set; }

    public decimal? CutPercentage { get; set; }

    public DateTime? ValidFromDate { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
