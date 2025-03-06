using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransChargesVisiteItemRealization
{
    public string TransactionNo { get; set; }

    public string ItemId { get; set; }

    public string RegistrationNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
