using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DietComplicationPatient
{
    public string TransactionNo { get; set; }

    public string DietId { get; set; }

    public string DietComplicationId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
