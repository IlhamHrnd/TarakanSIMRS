using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MedicationReceive
{
    public long MedicationReceiveNo { get; set; }

    public string RegistrationNo { get; set; }

    public DateTime? ReceiveDateTime { get; set; }

    public string ItemId { get; set; }

    public string ItemDescription { get; set; }

    public string RefTransactionNo { get; set; }

    public string RefSequenceNo { get; set; }

    public decimal? RefQty { get; set; }

    public decimal ReceiveQty { get; set; }

    public string SrconsumeUnit { get; set; }

    public decimal? ConsumeQty { get; set; }

    public string SrconsumeMethod { get; set; }

    public decimal BalanceQty { get; set; }

    public DateTime? StartDateTime { get; set; }

    public bool? IsClosed { get; set; }

    public bool? IsVoid { get; set; }

    public bool? IsContinue { get; set; }

    public string Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsAdmissionAppropriate { get; set; }

    public bool? IsTransferAppropriate { get; set; }

    public bool? IsDischargeAppropriate { get; set; }

    public bool? IsBroughtHome { get; set; }

    public decimal? BalanceRealQty { get; set; }

    public DateTime? AdmissionAppropriateDateTime { get; set; }

    public DateTime? TransferAppropriateDateTime { get; set; }

    public DateTime? DischargeAppropriateDateTime { get; set; }

    public string SrmedicationConsume { get; set; }

    public bool? IsAdmissionPresc { get; set; }

    public bool? IsTransferPresc { get; set; }

    public bool? IsDischargePresc { get; set; }

    public string ServiceUnitId { get; set; }

    public string RoomId { get; set; }

    public string BedId { get; set; }

    public string ConsumeQtyInString { get; set; }

    public string SrmedicationRoute { get; set; }

    public bool? IsApproveAdm { get; set; }

    public DateTime? ApproveAdmDateTime { get; set; }

    public string ApproveAdmByUserId { get; set; }
}
