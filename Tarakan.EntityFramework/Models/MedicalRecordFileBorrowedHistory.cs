using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MedicalRecordFileBorrowedHistory
{
    public string TransactionNo { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public short Duration { get; set; }
}
