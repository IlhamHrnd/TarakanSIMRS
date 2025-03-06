using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationGuarantorHistory
{
    public string RegistrationNo { get; set; }

    public string FromGuarantorId { get; set; }

    public string ToGuarantorId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
