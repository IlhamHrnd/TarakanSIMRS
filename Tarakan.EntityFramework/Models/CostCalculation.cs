﻿using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CostCalculation
{
    public string RegistrationNo { get; set; }

    public string TransactionNo { get; set; }

    public string SequenceNo { get; set; }

    public string ItemId { get; set; }

    public decimal PatientAmount { get; set; }

    public decimal GuarantorAmount { get; set; }

    public decimal DiscountAmount { get; set; }

    public decimal ParamedicAmount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public decimal? ParamedicFeeAmount { get; set; }

    public string ParamedicFeePaymentNo { get; set; }

    public bool IsPackage { get; set; }

    public string ParentNo { get; set; }

    public string IntermBillNo { get; set; }

    public bool? IsChecked { get; set; }

    public decimal? DiscountAmount2 { get; set; }

    public decimal? AmountAdjusted { get; set; }

    public decimal? AdjustedDiscAmount { get; set; }

    public int? AdjustedDiscSelection { get; set; }
}
