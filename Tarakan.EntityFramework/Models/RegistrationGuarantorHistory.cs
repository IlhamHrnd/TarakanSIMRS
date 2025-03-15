using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationGuarantorHistory
{
    public string RegistrationNo { get; set; } = null!;

    public string FromGuarantorId { get; set; } = null!;

    public string ToGuarantorId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
