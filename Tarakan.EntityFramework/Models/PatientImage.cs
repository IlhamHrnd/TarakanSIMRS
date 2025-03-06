using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientImage
{
    public string PatientId { get; set; }

    public byte[] Photo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
