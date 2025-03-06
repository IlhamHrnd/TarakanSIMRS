using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ServiceFeeRemunRsucdr
{
    public int RemunId { get; set; }

    public string RemunNo { get; set; }

    public int PeriodYear { get; set; }

    public int PeriodMonth { get; set; }

    public bool IsBpjs { get; set; }

    public string Notes { get; set; }

    public DateTime? DischargeDateFrom { get; set; }

    public DateTime? DischargeDateTo { get; set; }

    public decimal InvoiceAmount { get; set; }

    public decimal BudgetPercentage { get; set; }

    public decimal BudgetAllocation { get; set; }

    public decimal DeductionAmount { get; set; }

    public decimal BudgetAmount { get; set; }

    public decimal TotalFeeDirektur { get; set; }

    public decimal TotalFeeStruktural { get; set; }

    public decimal TotalFeeMedis { get; set; }

    public decimal TotalFeeMedisIgd { get; set; }

    public decimal TotalFeeUnit { get; set; }

    public decimal TotalFeePemerataan { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public bool IsApproved { get; set; }

    public string ApprovedByUserId { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public bool IsVoid { get; set; }

    public string VoidByUserId { get; set; }

    public DateTime? VoidDateTime { get; set; }
}
