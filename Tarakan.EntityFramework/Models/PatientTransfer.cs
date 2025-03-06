using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientTransfer
{
    public string TransferNo { get; set; }

    public string RegistrationNo { get; set; }

    public string DepartmentId { get; set; }

    public string TransactionCode { get; set; }

    public DateTime TransferDate { get; set; }

    public string TransferTime { get; set; }

    public string FromServiceUnitId { get; set; }

    public string FromClassId { get; set; }

    public string FromRoomId { get; set; }

    public string FromBedId { get; set; }

    public string FromChargeClassId { get; set; }

    public string FromSpecialtyId { get; set; }

    public string ToServiceUnitId { get; set; }

    public string ToClassId { get; set; }

    public string ToRoomId { get; set; }

    public string ToBedId { get; set; }

    public string ToChargeClassId { get; set; }

    public string ToSpecialtyId { get; set; }

    public bool IsApprove { get; set; }

    public bool IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsRoomInFrom { get; set; }

    public bool? IsRoomInTo { get; set; }

    public bool? IsValidated { get; set; }

    public string ValidatedByUserId { get; set; }

    public DateTime? ValidatedDateTime { get; set; }

    public virtual Registration RegistrationNoNavigation { get; set; }
}
