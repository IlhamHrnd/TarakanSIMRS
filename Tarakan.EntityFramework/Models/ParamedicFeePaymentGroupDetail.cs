using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicFeePaymentGroupDetail
{
    public string PaymentGroupNo { get; set; }

    public string ParamedicId { get; set; }

    public decimal AmountFee4Service { get; set; }

    public decimal AmountAddDec { get; set; }

    public decimal AmountGuarantee { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }
}
