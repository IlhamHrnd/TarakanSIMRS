using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PaymentMethod
{
    public string SrpaymentTypeId { get; set; }

    public string SrpaymentMethodId { get; set; }

    public string PaymentMethodName { get; set; }

    public int? ChartOfAccountId { get; set; }

    public int? SubledgerId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
