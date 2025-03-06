using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicFeeAddDeduc
{
    public string TransactionNo { get; set; }

    public DateOnly TransactionDate { get; set; }

    public string ParamedicId { get; set; }

    public string SrparamedicFeeAdjustType { get; set; }

    public string Notes { get; set; }

    public decimal Amount { get; set; }

    public bool? IsApproved { get; set; }

    public string VerificationNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdatedByUserId { get; set; }

    public bool? IsIncludeInTaxCalc { get; set; }

    public string TariffComponentId { get; set; }

    public int? ChartOfAccountId { get; set; }

    public int? SubledgerId { get; set; }

    public string ChartOfAccountTemplateId { get; set; }

    public string PaymentGroupNo { get; set; }

    public decimal? Price { get; set; }
}
