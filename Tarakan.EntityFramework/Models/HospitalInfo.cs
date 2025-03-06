using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class HospitalInfo
{
    public int HospitalInfoId { get; set; }

    public string HospitalName { get; set; }

    public string Address { get; set; }

    public string Srstate { get; set; }

    public string Srcity { get; set; }

    public string ZipCode { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
