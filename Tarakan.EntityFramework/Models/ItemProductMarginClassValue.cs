using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemProductMarginClassValue
{
    public string MarginId { get; set; }

    public string SequenceNo { get; set; }

    public string ClassId { get; set; }

    public decimal MarginValuePercentage { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
