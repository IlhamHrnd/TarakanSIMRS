﻿using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PersonalAddress
{
    public int PersonalAddressId { get; set; }

    public int PersonId { get; set; }

    public string SraddressType { get; set; }

    public string Address { get; set; }

    public string Srstate { get; set; }

    public string Srcity { get; set; }

    public string ZipCode { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string District { get; set; }

    public string County { get; set; }

    public string City { get; set; }
}
