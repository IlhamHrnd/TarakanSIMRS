using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BloodBankTransaction
{
    public string TransactionNo { get; set; }

    public DateTime? TransactionDate { get; set; }

    public DateTime? RequestDate { get; set; }

    public string RequestTime { get; set; }

    public string BloodBankNo { get; set; }

    public string PdutNo { get; set; }

    public string RegistrationNo { get; set; }

    public string SrbloodGroupRequest { get; set; }

    public decimal? HbResultValue { get; set; }

    public short? QtyBagRequest { get; set; }

    public decimal? VolumeBag { get; set; }

    public string Diagnose { get; set; }

    public string Reason { get; set; }

    public string OfficerByUserId { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string VoidByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsValidatedByCasemix { get; set; }

    public DateTime? ValidatedByCasemixDateTime { get; set; }

    public string ValidatedByCasemixUserId { get; set; }

    public bool? IsBloodSampleGiven { get; set; }

    public DateTime? BloodSampleSubmittedDateTime { get; set; }

    public string BloodSampleSubmittedByUserId { get; set; }

    public string BloodSampleReceivedByUserId { get; set; }

    public DateTime? BloodSampleReceivedDateTime { get; set; }

    public DateTime? BloodSampleTakenDateTime { get; set; }

    public string BloodSampleTakenByUserId { get; set; }

    public string CasemixNotes { get; set; }

    public short? QtyBagCasemixAppr { get; set; }
}
