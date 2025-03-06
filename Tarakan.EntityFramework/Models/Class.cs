using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Class
{
    public string ClassId { get; set; }

    public string ClassName { get; set; }

    public string ShortName { get; set; }

    public string SrclassRl { get; set; }

    public decimal MarginPercentage { get; set; }

    public decimal DepositAmount { get; set; }

    public bool IsInPatientClass { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public decimal? Margin2Percentage { get; set; }

    public string BpjsClassId { get; set; }

    public bool? IsTariffClass { get; set; }

    public short? ClassSeq { get; set; }
}
