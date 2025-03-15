using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransChargesItemImage
{
    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public int ImageNo { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public string DocumentName { get; set; } = null!;

    public byte[] DocumentImage { get; set; } = null!;

    public string? DocumentNotes { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public string CreatedByUserId { get; set; } = null!;
}
