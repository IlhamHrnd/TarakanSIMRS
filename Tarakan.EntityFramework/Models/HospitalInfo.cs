using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class HospitalInfo
{
    public int HospitalInfoId { get; set; }

    public string HospitalName { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Srstate { get; set; } = null!;

    public string? Srcity { get; set; }

    public string? ZipCode { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
