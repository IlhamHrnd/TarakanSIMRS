using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransCharge
{
    public string TransactionNo { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public DateTime ExecutionDate { get; set; }

    public string ReferenceNo { get; set; } = null!;

    public string FromServiceUnitId { get; set; } = null!;

    public string? ToServiceUnitId { get; set; }

    public string ClassId { get; set; } = null!;

    public string? RoomId { get; set; }

    public string? BedId { get; set; }

    public DateTime DueDate { get; set; }

    public string? Srshift { get; set; }

    public string? SritemType { get; set; }

    public bool IsProceed { get; set; }

    public bool IsApproved { get; set; }

    public bool IsVoid { get; set; }

    public bool IsOrder { get; set; }

    public bool IsCorrection { get; set; }

    public bool IsClusterAssign { get; set; }

    public bool IsAutoBillTransaction { get; set; }

    public bool IsBillProceed { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public string? SrtypeResult { get; set; }

    public string? ResponUnitId { get; set; }

    public string? SurgicalPackageId { get; set; }

    public bool? IsPackage { get; set; }

    public string? PackageReferenceNo { get; set; }

    public bool? IsRoomIn { get; set; }

    public decimal? TariffDiscountForRoomIn { get; set; }

    public bool? IsNonPatient { get; set; }

    public string? ServiceUnitBookingNo { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public string? PhysicianSenders { get; set; }

    public bool? IsValidated { get; set; }

    public DateTime? ValidatedDateTime { get; set; }

    public string? ValidatedByUserId { get; set; }

    public string? LocationId { get; set; }

    public string? SrprodiaContractId { get; set; }

    public string? LaboratoryParamedicId { get; set; }

    public string? SrbloodSampleTakenBy { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ApprovedByUserId { get; set; }

    public string? AnalystId { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string? VoidByUserId { get; set; }

    public string? SrorderStatus { get; set; }

    public string? ResultReadByPhysicianId { get; set; }

    public DateTime? ResultReadByPhysicianDateTime { get; set; }

    public string? ClinicalDiagnosis { get; set; }

    public bool? IsExecDateVerify { get; set; }

    public virtual Registration RegistrationNoNavigation { get; set; } = null!;

    public virtual ICollection<TransChargesItem> TransChargesItems { get; set; } = new List<TransChargesItem>();
}
