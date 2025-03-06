﻿using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwHasilLabMobileSysmex
{
    public string MedicalNo { get; set; }

    public string RegistrationNo { get; set; }

    public string TransactionNo { get; set; }

    public DateTime RegistrationDate { get; set; }

    public DateTime TransactionDate { get; set; }

    public string TestGroup { get; set; }

    public string TestCode { get; set; }

    public string TestName { get; set; }

    public string Result { get; set; }

    public string Flag { get; set; }

    public string NormalResult { get; set; }

    public string TestComment { get; set; }
}
