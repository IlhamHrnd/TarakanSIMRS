using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MappingRanap
{
    public string ServiceunitId { get; set; }

    public double? SubLedgerId { get; set; }

    public string GroupId { get; set; }

    public string NamaGroup { get; set; }

    public string KodeItem { get; set; }

    public string NamaItem { get; set; }

    public string KodeIdi { get; set; }

    public string CoaRevenueOpr { get; set; }

    public double? CoaRevenueIpr { get; set; }
}
