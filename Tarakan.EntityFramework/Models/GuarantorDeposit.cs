using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class GuarantorDeposit
{
    public string TransactionNo { get; set; }

    public DateTime TransactionDate { get; set; }

    public string GuarantorId { get; set; }

    public string SrpaymentType { get; set; }

    public string SrpaymentMethod { get; set; }

    public string SrcardProvider { get; set; }

    public string SrcardType { get; set; }

    public string EdcmachineId { get; set; }

    public string CardHolderName { get; set; }

    public string BankId { get; set; }

    public string BankAccountNo { get; set; }

    public decimal? Amount { get; set; }

    public string Notes { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
