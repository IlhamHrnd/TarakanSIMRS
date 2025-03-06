using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ServiceUnitAutoBillItem
{
    public string ServiceUnitId { get; set; }

    public string ItemId { get; set; }

    public decimal Quantity { get; set; }

    public string SritemUnit { get; set; }

    public bool IsAutoPayment { get; set; }

    public bool IsActive { get; set; }

    public bool IsGenerateOnRegistration { get; set; }

    public bool? IsGenerateOnNewRegistration { get; set; }

    public bool IsGenerateOnReferral { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsGenerateOnFirstRegistration { get; set; }

    public bool? IsGenerateOnSchedule { get; set; }

    public string GenerateOnClassIds { get; set; }

    public int? GenerateOnDayStart { get; set; }

    public int? GenerateOnDayEnd { get; set; }
}
