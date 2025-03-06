using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPaymentReceipt
{
    public string PaymentReceiptNo { get; set; }

    public DateTime PaymentReceiptDate { get; set; }

    public string PaymentReceiptTime { get; set; }

    public string RegistrationNo { get; set; }

    public string PrintReceiptAsName { get; set; }

    public byte PrintNumber { get; set; }

    public bool? IsPrinted { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string ApprovedByUserId { get; set; }

    public bool IsVoid { get; set; }

    public DateTime? VoidDate { get; set; }

    public string VoidByUserId { get; set; }

    public string Notes { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public virtual ICollection<TransPaymentReceiptItem> TransPaymentReceiptItems { get; set; } = new List<TransPaymentReceiptItem>();
}
