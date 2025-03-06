using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CredentialProcessDocument
{
    public string TransactionNo { get; set; }

    public string DocumentItemId { get; set; }

    public string Notes { get; set; }

    public bool? IsVerified { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
