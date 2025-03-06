using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DocumentSignature
{
    public string TransactionNo { get; set; }

    public string SrtransactionCode { get; set; }

    public string SritemType { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
