using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BillingToPatient
{
    public string BillingNo { get; set; } = null!;

    public DateTime BillingCreatedDateTime { get; set; }

    public string BillingCreatedByUserId { get; set; } = null!;

    public DateTime? BillingDate { get; set; }

    public string? SrbillingType { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string? ServiceUnitId { get; set; }

    public string? RoomId { get; set; }

    public string? BedId { get; set; }

    public string? ClassId { get; set; }

    public string? ChargeClassId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public decimal? TransactionAmount { get; set; }

    public decimal? DownPaymentAmount { get; set; }

    public decimal? PlafondAmount { get; set; }

    public decimal? RemainingAmount { get; set; }

    public string? Notes { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserId { get; set; }

    public decimal? PaymentAmount { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string? PaymentByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
