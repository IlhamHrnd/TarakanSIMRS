using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MedicalBenefitClaimItem
{
    public int MedicalBenefitClaimItemId { get; set; }

    public int MedicalBenefitClaimId { get; set; }

    public int TreatedId { get; set; }

    public string ReceiptNo { get; set; }

    public DateTime? TreatmentDate { get; set; }

    public string VisitTypeId { get; set; }

    public string PhysicianName { get; set; }

    public int? HospitalInfoId { get; set; }

    public bool? IsOccupationalInjury { get; set; }

    public decimal? AmountOnBill { get; set; }

    public decimal? ReAmount { get; set; }

    public decimal? ApprovedAmount { get; set; }

    public string Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
