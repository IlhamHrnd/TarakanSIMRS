using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VRegistrationDisplayEmergencyTrk
{
    public string MedicalNo { get; set; }

    public string PatientName { get; set; }

    public string RegDate { get; set; }

    public string Expr1 { get; set; }

    public int? Jam1 { get; set; }

    public string Jam { get; set; }

    public string RegistrationNo { get; set; }

    public string SrregistrationType { get; set; }

    public string ParamedicId { get; set; }

    public string GuarantorId { get; set; }

    public string PatientId { get; set; }

    public string ClassId { get; set; }

    public DateTime RegistrationDate { get; set; }

    public string RegistrationTime { get; set; }

    public string AppointmentNo { get; set; }

    public byte AgeInYear { get; set; }

    public byte AgeInMonth { get; set; }

    public byte AgeInDay { get; set; }

    public string Srshift { get; set; }

    public string SrpatientInType { get; set; }

    public string InsuranceId { get; set; }

    public string SrpatientCategory { get; set; }

    public string SrercaseType { get; set; }

    public string SrvisitReason { get; set; }

    public string SrbussinesMethod { get; set; }

    public decimal? PlavonAmount { get; set; }

    public string DepartmentId { get; set; }

    public string ServiceUnitId { get; set; }

    public string RoomId { get; set; }

    public string BedId { get; set; }

    public string ChargeClassId { get; set; }

    public string CoverageClassId { get; set; }

    public string VisitTypeId { get; set; }

    public string ReferralId { get; set; }

    public string Anamnesis { get; set; }

    public string Complaint { get; set; }

    public string InitialDiagnose { get; set; }

    public string MedicationPlanning { get; set; }

    public string Srtriage { get; set; }

    public bool IsPrintingPatientCard { get; set; }

    public DateTime? DischargeDate { get; set; }

    public string DischargeTime { get; set; }

    public string DischargeMedicalNotes { get; set; }

    public string DischargeNotes { get; set; }

    public string SrdischargeCondition { get; set; }

    public string SrdischargeMethod { get; set; }

    public byte LosinYear { get; set; }

    public byte LosinMonth { get; set; }

    public byte LosinDay { get; set; }

    public string DischargeOperatorId { get; set; }

    public string AccountNo { get; set; }

    public decimal TransactionAmount { get; set; }

    public decimal AdministrationAmount { get; set; }

    public decimal RoundingAmount { get; set; }

    public decimal RemainingAmount { get; set; }

    public bool IsTransferedToInpatient { get; set; }

    public bool IsNewPatient { get; set; }

    public bool IsNewBornInfant { get; set; }

    public bool IsParturition { get; set; }

    public bool IsHoldTransactionEntry { get; set; }

    public bool IsHasCorrection { get; set; }

    public bool? IsEmrvalid { get; set; }

    public bool? IsBackDate { get; set; }

    public DateTime? ActualVisitDate { get; set; }

    public bool? IsVoid { get; set; }

    public string SrvoidReason { get; set; }

    public string VoidNotes { get; set; }

    public DateTime? VoidDate { get; set; }

    public string VoidByUserId { get; set; }

    public bool? IsClosed { get; set; }

    public bool? IsEpisodeComplete { get; set; }

    public bool? IsClusterAssessment { get; set; }

    public bool? IsConsul { get; set; }

    public bool? IsFromDispensary { get; set; }

    public bool? IsNewVisit { get; set; }

    public string Notes { get; set; }

    public DateTime? LastCreateDateTime { get; set; }

    public string LastCreateUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool IsDirectPrescriptionReturn { get; set; }

    public int? RegistrationQue { get; set; }

    public string VisiteRegistrationNo { get; set; }

    public bool IsGenerateHl7 { get; set; }

    public string ReferralName { get; set; }

    public bool? IsObservation { get; set; }

    public string CauseOfAccident { get; set; }

    public string ReferTo { get; set; }

    public bool? IsOldCase { get; set; }

    public bool? IsDhf { get; set; }

    public bool? IsEkg { get; set; }

    public string EmrDiagnoseId { get; set; }

    public bool? IsGlobalPlafond { get; set; }

    public DateTime? FirstResponDate { get; set; }

    public string FirstResponTime { get; set; }

    public DateTime? PhysicianResponDate { get; set; }

    public string PhysicianResponTime { get; set; }

    public bool? IsRoomIn { get; set; }

    public bool? IsLockVerifiedBilling { get; set; }

    public DateTime? LockVerifiedBillingDateTime { get; set; }

    public string LockVerifiedBillingByUserId { get; set; }

    public string ProcedureChargeClassId { get; set; }

    public int? PersonId { get; set; }

    public string EmployeeNumber { get; set; }

    public string SremployeeRelationship { get; set; }

    public string GuarantorCardNo { get; set; }

    public DateTime? DischargePlanDate { get; set; }

    public string UsertInsertDischargePlan { get; set; }

    public bool? IsNonPatient { get; set; }

    public string ReasonsForTreatmentId { get; set; }

    public string SmfId { get; set; }

    public decimal? PatientAdm { get; set; }

    public decimal? GuarantorAdm { get; set; }

    public string ReasonsForTreatmentDescId { get; set; }

    public string SrreferralGroup { get; set; }

    public string SrdiscountReason { get; set; }

    public string PhysicianSenders { get; set; }

    public decimal? DiscAdmPatient { get; set; }

    public decimal? DiscAdmGuarantor { get; set; }

    public string SrpatientInCondition { get; set; }

    public string SrkiaCaseType { get; set; }

    public string SrobstetricType { get; set; }

    public string IsHoldTransactionEntryByUserId { get; set; }

    public string FromRegistrationNo { get; set; }

    public bool? IsConfirmedAttendance { get; set; }

    public string ConfirmedAttendanceByUserId { get; set; }

    public DateTime? ConfirmedAttendanceDateTime { get; set; }

    public string BpjsSepNo { get; set; }

    public decimal? PlavonAmount2 { get; set; }

    public string DeathCertificateNo { get; set; }

    public decimal? BpjsCoverageFormula { get; set; }

    public string BpjsPackageId { get; set; }

    public decimal? ApproximatePlafondAmount { get; set; }

    public DateTime? SentToBillingDateTime { get; set; }

    public string SentToBillingByUserId { get; set; }

    public bool? IsAdjusted { get; set; }

    public string AdjustLog { get; set; }

    public bool? IsAllowPatientCheckOut { get; set; }

    public DateTime? AllowPatientCheckOutDateTime { get; set; }

    public string AllowPatientCheckOutByUserId { get; set; }

    public string ReferByParamedicId { get; set; }

    public string SrmaritalStatus { get; set; }

    public string Sroccupation { get; set; }

    public string SrrelationshipQuality { get; set; }

    public string SrresidentialHome { get; set; }

    public string SrfatherOccupation { get; set; }

    public bool? IsPregnant { get; set; }

    public short? GestationalAge { get; set; }

    public bool? IsBreastFeeding { get; set; }

    public short? AgeOfBabyInYear { get; set; }

    public short? AgeOfBabyInMonth { get; set; }

    public short? AgeOfBabyInDay { get; set; }

    public bool? IsKidneyFunctionImpaired { get; set; }

    public short? CreatinineSerumValue { get; set; }

    public string Hpi { get; set; }

    public long? MembershipDetailId { get; set; }

    public string ExternalQueNo { get; set; }

    public string ReferralIdTo { get; set; }

    public string ReferralNameTo { get; set; }

    public bool? IsReconcile { get; set; }

    public bool? IsSkipAutoBill { get; set; }

    public string SrcrashSite { get; set; }

    public string CrashSiteDetail { get; set; }

    public string MembershipNo { get; set; }

    public bool? IsOpenEntryMr { get; set; }

    public byte? SrcovidStatus { get; set; }

    public string VoucherNo { get; set; }

    public string SrcovidComorbidStatus { get; set; }

    public bool? IsDisability { get; set; }

    public bool? IsTracer { get; set; }

    public string ItemConditionRuleId { get; set; }
}
