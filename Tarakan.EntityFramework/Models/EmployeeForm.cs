﻿using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeForm
{
    public string TransactionNo { get; set; }

    public DateTime TransactionDate { get; set; }

    public int PersonId { get; set; }

    public int TemplateId { get; set; }

    public string Notes { get; set; }

    public string Result { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
