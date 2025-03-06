using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MedicalBenefitClaim
{
    public int MedicalBenefitClaimId { get; set; }

    public int PersonId { get; set; }

    public DateTime ClaimDate { get; set; }

    public int MedicalBenefitInfoId { get; set; }

    public int YearPeriodId { get; set; }

    public DateTime? SettlementDate { get; set; }

    public bool IsApproved { get; set; }

    public decimal TotalAmountOnBill { get; set; }

    public decimal TotalReimbursementAmount { get; set; }

    public decimal TotalNonReimbursementAmount { get; set; }

    public decimal TotalApprovedAmount { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
