using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MedicalDischargeSummaryPrescHomeBak
{
    public long MedicationReceiveNo { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public DateTime? ReceiveDateTime { get; set; }

    public string? ItemId { get; set; }

    public string? ItemDescription { get; set; }

    public string? RefTransactionNo { get; set; }

    public string? RefSequenceNo { get; set; }

    public decimal? RefQty { get; set; }

    public decimal ReceiveQty { get; set; }

    public string? SrconsumeUnit { get; set; }

    public decimal? ConsumeQty { get; set; }

    public string? SrconsumeMethod { get; set; }

    public decimal BalanceQty { get; set; }

    public DateTime? StartDateTime { get; set; }

    public bool? IsClosed { get; set; }

    public bool? IsVoid { get; set; }

    public bool? IsContinue { get; set; }

    public string? Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public bool? IsAdmissionAppropriate { get; set; }

    public bool? IsTransferAppropriate { get; set; }

    public bool? IsDischargeAppropriate { get; set; }

    public bool? IsBroughtHome { get; set; }

    public decimal? BalanceRealQty { get; set; }

    public DateTime? AdmissionAppropriateDateTime { get; set; }

    public DateTime? TransferAppropriateDateTime { get; set; }

    public DateTime? DischargeAppropriateDateTime { get; set; }

    public string? SrmedicationConsume { get; set; }

    public string? ServiceUnitId { get; set; }

    public string? RoomId { get; set; }

    public string? BedId { get; set; }

    public bool? IsAdmissionPresc { get; set; }

    public bool? IsTransferPresc { get; set; }

    public bool? IsDischargePresc { get; set; }

    public string? ConsumeQtyInString { get; set; }

    public string? SrmedicationRoute { get; set; }
}
