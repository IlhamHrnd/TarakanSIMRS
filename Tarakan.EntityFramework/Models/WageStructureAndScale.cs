using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class WageStructureAndScale
{
    public int WageStructureAndScaleId { get; set; }

    public string SrwageStructureAndScaleType { get; set; }

    public string WageStructureAndScaleCode { get; set; }

    public string WageStructureAndScaleName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
