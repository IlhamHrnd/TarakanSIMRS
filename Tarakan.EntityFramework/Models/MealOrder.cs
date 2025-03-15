using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MealOrder
{
    public string OrderNo { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public DateTime EffectiveDate { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string ServiceUnitId { get; set; } = null!;

    public string ClassId { get; set; } = null!;

    public string? BedId { get; set; }

    public string? DietPatientNo { get; set; }

    public string? DietId { get; set; }

    public string? MenuId { get; set; }

    public string? MenuItemId { get; set; }

    public string? FastingTime { get; set; }

    public bool? IsAdditional { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? VersionId { get; set; }

    public string? SeqNo { get; set; }

    public bool? IsVerified { get; set; }

    public DateTime? VerifiedDateTime { get; set; }

    public string? VerifiedByUserId { get; set; }

    public bool? IsOpr { get; set; }
}
