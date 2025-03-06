using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PpiProcedureSurveillanceUseOfAntibiotic
{
    public string BookingNo { get; set; }

    public string ItemId { get; set; }

    public DateTime StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
