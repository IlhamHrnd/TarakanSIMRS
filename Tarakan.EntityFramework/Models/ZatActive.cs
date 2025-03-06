using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ZatActive
{
    public string ZatActiveId { get; set; }

    public string ZatActiveName { get; set; }

    public bool IsActive { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public string InsertByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public decimal? DddOral { get; set; }

    public decimal? DddParenteral { get; set; }

    public string SrzatActiveGroup { get; set; }
}
