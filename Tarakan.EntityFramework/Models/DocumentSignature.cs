using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DocumentSignature
{
    public string TransactionNo { get; set; } = null!;

    public string SrtransactionCode { get; set; } = null!;

    public string SritemType { get; set; } = null!;

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
