using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MedicationReconLine
{
    public string RegistrationNo { get; set; } = null!;

    public int ReconSeqNo { get; set; }

    public long MedicationReceiveNo { get; set; }

    public string? ReconStatus { get; set; }

    public string? SrconsumeMethod { get; set; }

    public string? ConsumeQty { get; set; }

    public string? SrconsumeUnit { get; set; }

    public string? SrmedicationConsume { get; set; }

    public bool? IsApprove { get; set; }

    public DateTime? ApproveDateTime { get; set; }

    public string? ApproveByParamedicId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
