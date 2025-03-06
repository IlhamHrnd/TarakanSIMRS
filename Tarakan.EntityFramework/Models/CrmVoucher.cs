using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CrmVoucher
{
    public string VoucherNo { get; set; }

    public string VoucherName { get; set; }

    public string Summary { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string Ssn { get; set; }

    public string GuarantorId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string CreatedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public string VoidReason { get; set; }

    public bool? IsUsed { get; set; }

    public string RegistrationNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
