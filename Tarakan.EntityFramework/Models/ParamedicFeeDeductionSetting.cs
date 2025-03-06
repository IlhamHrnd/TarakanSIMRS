using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicFeeDeductionSetting
{
    public int DeductionId { get; set; }

    public string SrparamedicFeeDeduction { get; set; }

    public string SrregistrationType { get; set; }

    public string GuarantorId { get; set; }

    public string ServiceUnitId { get; set; }

    public string SrparamedicFeeDeductionMethod { get; set; }

    public bool IsDeductionValueInPercent { get; set; }

    public decimal DeductionValue { get; set; }

    public bool? IsActive { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string SrguarantorType { get; set; }

    public bool? IsMainPhysicianOnly { get; set; }

    public string TariffComponentId { get; set; }

    public bool? IsAfterTax { get; set; }

    public virtual ICollection<ParamedicFeeDeduction> ParamedicFeeDeductions { get; set; } = new List<ParamedicFeeDeduction>();
}
