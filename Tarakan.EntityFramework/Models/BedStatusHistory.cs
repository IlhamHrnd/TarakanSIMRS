using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BedStatusHistory
{
    public long TransactionId { get; set; }

    public string BedId { get; set; }

    public string SrbedStatusFrom { get; set; }

    public string SrbedStatusTo { get; set; }

    public string RegistrationNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string TransferNo { get; set; }
}
