using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PaymentMethod
{
    public string SrpaymentTypeId { get; set; } = null!;

    public string SrpaymentMethodId { get; set; } = null!;

    public string PaymentMethodName { get; set; } = null!;

    public int? ChartOfAccountId { get; set; }

    public int? SubledgerId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
