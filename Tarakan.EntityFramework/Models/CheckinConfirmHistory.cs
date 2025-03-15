using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CheckinConfirmHistory
{
    public Guid CheckinConfirmId { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string TransferNo { get; set; } = null!;

    public string BedId { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
