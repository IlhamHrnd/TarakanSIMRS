using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class LocationTemplate
{
    public string TemplateNo { get; set; } = null!;

    public string TemplateName { get; set; } = null!;

    public string LocationId { get; set; } = null!;

    public bool? IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
