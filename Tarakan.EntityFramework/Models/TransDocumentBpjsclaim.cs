using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransDocumentBpjsclaim
{
    public string TransactionNo { get; set; } = null!;

    public string? RegistrationNo { get; set; }

    public bool? IsClaimDocument { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
