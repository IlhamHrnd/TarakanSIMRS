using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MealOrderNonPatientItem
{
    public string TransactionNo { get; set; }

    public string SequenceNo { get; set; }

    public string FoodId { get; set; }

    public decimal Qty { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
