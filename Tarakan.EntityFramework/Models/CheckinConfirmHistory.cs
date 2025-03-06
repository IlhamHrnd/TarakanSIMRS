using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CheckinConfirmHistory
{
    public Guid CheckinConfirmId { get; set; }

    public string RegistrationNo { get; set; }

    public string TransferNo { get; set; }

    public string BedId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
