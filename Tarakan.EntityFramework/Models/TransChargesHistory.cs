using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransChargesHistory
{
    public string RecalculationProcessNo { get; set; }

    public string TransactionNo { get; set; }

    public string RegistrationNo { get; set; }

    public DateTime TransactionDate { get; set; }

    public DateTime ExecutionDate { get; set; }

    public string ReferenceNo { get; set; }

    public string FromServiceUnitId { get; set; }

    public string ToServiceUnitId { get; set; }

    public string ClassId { get; set; }

    public string RoomId { get; set; }

    public string BedId { get; set; }

    public DateTime DueDate { get; set; }

    public string Srshift { get; set; }

    public string SritemType { get; set; }

    public bool IsProceed { get; set; }

    public bool IsApproved { get; set; }

    public bool IsVoid { get; set; }

    public bool IsOrder { get; set; }

    public bool IsCorrection { get; set; }

    public bool IsClusterAssign { get; set; }

    public bool IsAutoBillTransaction { get; set; }

    public bool IsBillProceed { get; set; }

    public string Notes { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string SrtypeResult { get; set; }

    public string ResponUnitId { get; set; }
}
