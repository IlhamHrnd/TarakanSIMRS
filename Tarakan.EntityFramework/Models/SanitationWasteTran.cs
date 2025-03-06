﻿using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SanitationWasteTran
{
    public string TransactionNo { get; set; }

    public DateTime TransactionDate { get; set; }

    public string TransactionCode { get; set; }

    public string FromServiceUnitId { get; set; }

    public string SupplierId { get; set; }

    public string Notes { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string VoidByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
