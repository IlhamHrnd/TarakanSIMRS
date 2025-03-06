using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPrescription
{
    public string PrescriptionNo { get; set; }

    public DateTime PrescriptionDate { get; set; }

    public string RegistrationNo { get; set; }

    public string ServiceUnitId { get; set; }

    public string ClassId { get; set; }

    public string ParamedicId { get; set; }

    public bool IsApproval { get; set; }

    public bool IsVoid { get; set; }

    public string Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool IsPrescriptionReturn { get; set; }

    public string ReferenceNo { get; set; }

    public bool IsFromSoap { get; set; }

    public bool IsBillProceed { get; set; }

    public bool IsUnitDosePrescription { get; set; }

    public bool IsCito { get; set; }

    public bool IsClosed { get; set; }

    public DateTime? ApprovalDateTime { get; set; }

    public DateTime? DeliverDateTime { get; set; }

    public string TextPrescription { get; set; }

    public bool? IsDirect { get; set; }

    public bool? IsPaid { get; set; }

    public string OrderNo { get; set; }

    public bool? IsProceedByPharmacist { get; set; }

    public string FullAddress { get; set; }

    public string NoTelp { get; set; }

    public string AdditionalNote { get; set; }

    public string Srfloor { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string CreatedByUserId { get; set; }

    public short? QtyR { get; set; }

    public string ApprovedByUserId { get; set; }

    public bool? IsPrinted { get; set; }

    public int? FloorSeqNo { get; set; }

    public string Rtype { get; set; }

    public string FromServiceUnitId { get; set; }

    public string FromRoomId { get; set; }

    public string FromBedId { get; set; }

    public string LocationId { get; set; }

    public DateTime? CompleteDateTime { get; set; }

    public string VoidReason { get; set; }

    public DateTime? ExecutionDate { get; set; }

    public bool? IsPos { get; set; }

    public bool? IsForTakeItHome { get; set; }

    public int? PatientEducationSeqNo { get; set; }

    public string ReviewByUserId { get; set; }

    public bool? IsUnapproved { get; set; }

    public DateTime? UnapprovedDateTime { get; set; }

    public string UnapprovedByUserId { get; set; }

    public string SrkioskQueueType { get; set; }

    public string KioskQueueNo { get; set; }

    public bool? IsVerified { get; set; }

    public string VerifiedByUserId { get; set; }

    public DateTime? VerifiedDateTime { get; set; }

    public string SrprescriptionCategory { get; set; }

    public int? RasproSeqNo { get; set; }

    public bool? IsReviewed { get; set; }

    public string ReviewedByUserId { get; set; }

    public DateTime? ReviewedDateTime { get; set; }

    public bool? Is23Days { get; set; }

    public bool? IsSplitBill { get; set; }

    public bool? IsCash { get; set; }

    public string DeliverByUserId { get; set; }

    public string CompleteByUserId { get; set; }

    public string InProgressByUserId { get; set; }

    public DateTime? InProgressDateTime { get; set; }

    public virtual ICollection<TransPrescriptionItem> TransPrescriptionItems { get; set; } = new List<TransPrescriptionItem>();
}
