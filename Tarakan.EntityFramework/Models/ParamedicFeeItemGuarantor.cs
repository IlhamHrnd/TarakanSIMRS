﻿using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicFeeItemGuarantor
{
    public string ParamedicId { get; set; }

    public string ItemId { get; set; }

    public string GuarantorId { get; set; }

    public bool IsParamedicFeeUsePercentage { get; set; }

    public decimal ParamedicFeeAmount { get; set; }

    public decimal ParamedicFeeAmountReferral { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsDeductionFeeUsePercentage { get; set; }

    public decimal? DeductionFeeAmount { get; set; }

    public decimal? DeductionFeeAmountReferral { get; set; }
}
