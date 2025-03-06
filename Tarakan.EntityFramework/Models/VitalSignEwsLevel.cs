using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VitalSignEwsLevel
{
    public string VitalSignId { get; set; }

    public int StartAgeInDay { get; set; }

    public decimal StartValue { get; set; }

    public int EwsLevel { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
