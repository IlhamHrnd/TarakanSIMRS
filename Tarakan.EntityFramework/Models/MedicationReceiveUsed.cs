using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MedicationReceiveUsed
{
    public long MedicationReceiveNo { get; set; }

    public int SequenceNo { get; set; }

    public DateTime? ScheduleDateTime { get; set; }

    public DateTime? SetupDateTime { get; set; }

    public string SetupByUserId { get; set; }

    public DateTime? VerificationDateTime { get; set; }

    public string VerificationByUserId { get; set; }

    public DateTime? RealizedDateTime { get; set; }

    public string RealizedByUserId { get; set; }

    public decimal Qty { get; set; }

    public string ParamedicId { get; set; }

    public string SrmedicationReason { get; set; }

    public bool? IsNotConsume { get; set; }

    public string Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsReSchedule { get; set; }

    public bool? IsVoidSchedule { get; set; }

    public bool? IsAdditionalSchedule { get; set; }
}
