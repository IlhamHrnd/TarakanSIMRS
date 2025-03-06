using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MealOrderNonPatient
{
    public string TransactionNo { get; set; }

    public DateTime TransactionDate { get; set; }

    public string RegistrationNo { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public bool? IsDistributed { get; set; }

    public DateTime? DistributedDateTime { get; set; }

    public string DistributedByUserId { get; set; }

    public DateTime? LastCreateDateTime { get; set; }

    public string LastCreateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
