using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationInfoMedic
{
    public string RegistrationInfoMedicId { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public string SrmedicalNotesInputType { get; set; } = null!;

    public DateTime DateTimeInfo { get; set; }

    public string Info1 { get; set; } = null!;

    public string Info2 { get; set; } = null!;

    public string Info3 { get; set; } = null!;

    public string Info4 { get; set; } = null!;

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? Info1Log { get; set; }

    public string? Info2Log { get; set; }

    public string? Info3Log { get; set; }

    public string? Info4Log { get; set; }

    public bool? IsDeleted { get; set; }

    public string? ServiceUnitId { get; set; }

    public string? AttendingNotes { get; set; }

    public bool? IsInformConcern { get; set; }

    public string? ParamedicId { get; set; }

    public DateTime? ApprovedDatetime { get; set; }

    public bool? IsApproved { get; set; }

    public string? ApprovedByUserId { get; set; }

    public bool? IsPrmrj { get; set; }

    public string? PpaInstruction { get; set; }

    public bool? IsCreatedByUserDpjp { get; set; }

    public string? SruserType { get; set; }

    public string? PrescriptionCurrentDay { get; set; }

    public string? ReferenceType { get; set; }

    public string? Info1Entry { get; set; }

    public string? Info3Entry { get; set; }

    public string? ReferenceNo { get; set; }

    public string? Info5 { get; set; }

    public string? DpjpNotes { get; set; }

    public string? ReceiveBy { get; set; }

    public virtual Registration RegistrationNoNavigation { get; set; } = null!;
}
