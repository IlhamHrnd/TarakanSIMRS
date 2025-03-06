using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DietLiquidPatient
{
    public string TransactionNo { get; set; }

    public string RegistrationNo { get; set; }

    public DateTime EffectiveStartDate { get; set; }

    public string EffectiveStartTime { get; set; }

    public string Notes { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string VoidByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
