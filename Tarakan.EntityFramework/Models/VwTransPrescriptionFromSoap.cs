﻿using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwTransPrescriptionFromSoap
{
    public string RegistrationNo { get; set; } = null!;

    public DateTime PrescriptionDate { get; set; }
}
