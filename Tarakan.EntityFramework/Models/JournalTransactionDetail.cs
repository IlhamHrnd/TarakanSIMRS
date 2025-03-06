using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class JournalTransactionDetail
{
    public int DetailId { get; set; }

    public int JournalId { get; set; }

    public int ChartOfAccountId { get; set; }

    public decimal Debit { get; set; }

    public decimal Credit { get; set; }

    public string Description { get; set; }

    public int SubLedgerId { get; set; }

    public string DocumentNumber { get; set; }

    public int? DocumentPageNo { get; set; }

    public string ClassId { get; set; }

    public string GuarantorId { get; set; }

    public string SupplierId { get; set; }

    public string ParamedicId { get; set; }

    public DateTime? DueDate { get; set; }

    public string ServiceUnitId { get; set; }

    public string ItemId { get; set; }

    public string DocumentNumberSequenceNo { get; set; }

    public string RegistrationNo { get; set; }

    public DateTime? DateCreated { get; set; }

    public string CreatedBy { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsProrataDiscToRevenue { get; set; }

    public virtual ChartOfAccount ChartOfAccount { get; set; }

    public virtual JournalTransaction Journal { get; set; }
}
