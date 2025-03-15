using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NursingTransHd
{
    public string TransactionNo { get; set; } = null!;

    public DateTime NursingTransDateTime { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string CreateByUserId { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }
}
