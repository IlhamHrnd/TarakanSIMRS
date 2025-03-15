using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PersonalAddress
{
    public int PersonalAddressId { get; set; }

    public int PersonId { get; set; }

    public string SraddressType { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Srstate { get; set; } = null!;

    public string? Srcity { get; set; }

    public string? ZipCode { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public string? District { get; set; }

    public string? County { get; set; }

    public string? City { get; set; }
}
