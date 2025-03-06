using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationEsoScale
{
    public string RegistrationNo { get; set; }

    public int EsoNo { get; set; }

    public string SresoScale { get; set; }

    public string ScaleStatus { get; set; }

    public int? ScaleValue { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
