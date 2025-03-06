using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class StandartSelectionProse
{
    public int StandartSelectionProsesId { get; set; }

    public string ProsesName { get; set; }

    public string Description { get; set; }

    public bool IsMandatory { get; set; }

    public string SrresultType { get; set; }

    public bool IsInternalCandidate { get; set; }

    public bool IsExsternalCandidate { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
