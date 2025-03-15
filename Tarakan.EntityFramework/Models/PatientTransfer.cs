using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientTransfer
{
    public string TransferNo { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public string DepartmentId { get; set; } = null!;

    public string TransactionCode { get; set; } = null!;

    public DateTime TransferDate { get; set; }

    public string TransferTime { get; set; } = null!;

    public string FromServiceUnitId { get; set; } = null!;

    public string FromClassId { get; set; } = null!;

    public string FromRoomId { get; set; } = null!;

    public string FromBedId { get; set; } = null!;

    public string FromChargeClassId { get; set; } = null!;

    public string FromSpecialtyId { get; set; } = null!;

    public string ToServiceUnitId { get; set; } = null!;

    public string ToClassId { get; set; } = null!;

    public string ToRoomId { get; set; } = null!;

    public string ToBedId { get; set; } = null!;

    public string ToChargeClassId { get; set; } = null!;

    public string ToSpecialtyId { get; set; } = null!;

    public bool IsApprove { get; set; }

    public bool IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public bool? IsRoomInFrom { get; set; }

    public bool? IsRoomInTo { get; set; }

    public bool? IsValidated { get; set; }

    public string? ValidatedByUserId { get; set; }

    public DateTime? ValidatedDateTime { get; set; }

    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
