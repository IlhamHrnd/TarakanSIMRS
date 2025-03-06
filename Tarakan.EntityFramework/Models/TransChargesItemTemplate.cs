using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransChargesItemTemplate
{
    public string TemplateNo { get; set; }

    public string SequenceNo { get; set; }

    public string ItemId { get; set; }

    public decimal ChargeQuantity { get; set; }

    public DateTime? LastCreateDateTime { get; set; }

    public string LastCreateUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
