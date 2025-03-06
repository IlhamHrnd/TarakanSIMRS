using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ServiceUnitBooking
{
    public string BookingNo { get; set; }

    public DateTime BookingDateTimeFrom { get; set; }

    public DateTime BookingDateTimeTo { get; set; }

    public string ServiceUnitId { get; set; }

    public string RoomId { get; set; }

    public string PatientId { get; set; }

    public string RegistrationNo { get; set; }

    public string ParamedicId { get; set; }

    public bool IsApproved { get; set; }

    public bool IsVoid { get; set; }

    public string Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? LastCreateDateTime { get; set; }

    public string LastCreateByUserId { get; set; }

    public string SranestesiPlan { get; set; }

    public string ParamedicId2 { get; set; }

    public string ParamedicId3 { get; set; }

    public string ParamedicId4 { get; set; }

    public string ParamedicIdanestesi { get; set; }

    public string AssistantId1 { get; set; }

    public string AssistantId2 { get; set; }

    public string AssistantId3 { get; set; }

    public string AssistantId4 { get; set; }

    public string AssistantIdanestesi { get; set; }

    public string Diagnose { get; set; }

    public string OperationType { get; set; }

    public bool? IsCito { get; set; }

    public string ProcedureChargeClassId { get; set; }

    public string OperatingNotes { get; set; }

    public string Instrumentator1 { get; set; }

    public string Instrumentator2 { get; set; }

    public string SrprocedureCategory { get; set; }

    public DateTime? RealizationDateTimeFrom { get; set; }

    public DateTime? RealizationDateTimeTo { get; set; }

    public string Resident { get; set; }

    public string AssistantIdinstrumentator { get; set; }

    public string SmfId { get; set; }

    public bool? IsExtendedSurgery { get; set; }

    public string Srindication { get; set; }

    public bool? IsNeedPa { get; set; }

    public string AssistantId5 { get; set; }

    public string AssistantIdinstrumentator2 { get; set; }

    public string AssistantIdinstrumentator3 { get; set; }

    public string AssistantIdinstrumentator4 { get; set; }

    public string AssistantIdinstrumentator5 { get; set; }

    public string Instrumentator3 { get; set; }

    public string Instrumentator4 { get; set; }

    public string Instrumentator5 { get; set; }

    public string AnestesyNotes { get; set; }

    public string Srprocedure1 { get; set; }

    public string Srprocedure2 { get; set; }

    public string PostDiagnosis { get; set; }

    public DateTime? PaDate { get; set; }

    public string SourceOfTissue { get; set; }

    public DateTime? ArrivedDateTime { get; set; }

    public bool? IsAnestheticConversion { get; set; }

    public bool? IsValidate { get; set; }

    public DateTime? ValidateDateTime { get; set; }

    public string ValidateByUserId { get; set; }

    public DateTime? PreSurgeryDateTime { get; set; }

    public string PreSurgeryByUserId { get; set; }

    public DateTime? AnesthesiaDateTime { get; set; }

    public string AnesthesiaByUserId { get; set; }

    public DateTime? SurgeryDateTime { get; set; }

    public string SurgeryByUserId { get; set; }

    public DateTime? PostSurgeryDateTime { get; set; }

    public string PostSurgeryByUserId { get; set; }

    public string VoidReason { get; set; }

    public string FromServiceUnitId { get; set; }

    public bool? IsInsertionImplant { get; set; }

    public DateTime? IncisionDateTime { get; set; }

    public string SrprocedureDiagnoseType { get; set; }

    public DateTime? MoveToTheWardDateTime { get; set; }

    public string MoveToTheWardByUserId { get; set; }

    public byte[] AnesthesiologistSign { get; set; }

    public virtual Paramedic Paramedic { get; set; }

    public virtual ServiceRoom Room { get; set; }

    public virtual ServiceUnit ServiceUnit { get; set; }
}
