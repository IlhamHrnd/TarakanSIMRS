using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RasproAction
{
    public string RasproLineId { get; set; }

    public string Condition { get; set; }

    public int ActionNo { get; set; }

    public string ActionDescription { get; set; }

    public int AntibioticLevel { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
