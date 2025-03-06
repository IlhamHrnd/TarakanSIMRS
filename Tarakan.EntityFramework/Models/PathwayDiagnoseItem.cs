using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PathwayDiagnoseItem
{
    public string PathwayId { get; set; }

    public string DiagnoseId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
