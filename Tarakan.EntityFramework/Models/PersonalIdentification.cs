using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PersonalIdentification
{
    public int PersonalIdentificationId { get; set; }

    public int PersonId { get; set; }

    public string SridentificationType { get; set; } = null!;

    public string? IdentificationValue { get; set; }

    public string? PlaceOfIssue { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public string? IdentificationName { get; set; }
}
