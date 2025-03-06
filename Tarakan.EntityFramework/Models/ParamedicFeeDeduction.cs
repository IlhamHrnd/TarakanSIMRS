using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicFeeDeduction
{
    public string TransactionNo { get; set; }

    public string SequenceNo { get; set; }

    public string TariffComponentId { get; set; }

    public string ParamedicId { get; set; }

    public int DeductionId { get; set; }

    public string RegistrationNo { get; set; }

    public string RegistrationNoMergeTo { get; set; }

    public bool IsCalculatedInPercent { get; set; }

    public string VerificationNo { get; set; }

    public decimal CalculatedAmount { get; set; }

    public decimal DeductionAmount { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public bool? IsAfterTax { get; set; }

    public virtual ParamedicFeeDeductionSetting Deduction { get; set; }
}
