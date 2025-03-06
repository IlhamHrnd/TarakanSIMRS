﻿using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BankReconcile
{
    public int ReconcileId { get; set; }

    public string BankId { get; set; }

    public decimal? DebitCashTransaction { get; set; }

    public decimal? CreditCashTransaction { get; set; }

    public decimal? DebitInquiry { get; set; }

    public decimal? CreditInquiry { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
