using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CredentialProcessLicense
{
    public string TransactionNo { get; set; }

    public string SrlicenseType { get; set; }

    public string LicenseNo { get; set; }

    public DateTime? DateOfIssue { get; set; }

    public DateTime? ValidUntil { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
