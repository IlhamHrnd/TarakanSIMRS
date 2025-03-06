using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NursingTransHd
{
    public string TransactionNo { get; set; }

    public DateTime NursingTransDateTime { get; set; }

    public string RegistrationNo { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }
}
