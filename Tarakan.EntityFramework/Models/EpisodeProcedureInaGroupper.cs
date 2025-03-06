using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EpisodeProcedureInaGroupper
{
    public string RegistrationNo { get; set; }

    public string SequenceNo { get; set; }

    public DateTime ProcedureDate { get; set; }

    public string ProcedureTime { get; set; }

    public DateTime ProcedureDate2 { get; set; }

    public string ProcedureTime2 { get; set; }

    public string ParamedicId { get; set; }

    public string ParamedicId2 { get; set; }

    public string ProcedureId { get; set; }

    public string SrprocedureCategory { get; set; }

    public string Sranestesi { get; set; }

    public string RoomId { get; set; }

    public bool IsCito { get; set; }

    public bool IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string AssistantId1 { get; set; }

    public string AssistantId2 { get; set; }

    public string Notes { get; set; }

    public string BookingNo { get; set; }

    public string ParamedicId2a { get; set; }

    public string ParamedicId3a { get; set; }

    public string ParamedicId4a { get; set; }

    public string ParamedicIdanestesi { get; set; }

    public string AssistantIdanestesi { get; set; }

    public string InstrumentatorId1 { get; set; }

    public string InstrumentatorId2 { get; set; }

    public bool? IsFromOperatingRoom { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string AnestesyNotes { get; set; }

    public string ProcedureName { get; set; }

    public string OpNotesSeqNo { get; set; }

    public string OperatingNotes { get; set; }
}
