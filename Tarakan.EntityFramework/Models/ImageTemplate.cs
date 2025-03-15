using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ImageTemplate
{
    public string ImageTemplateId { get; set; } = null!;

    public string? ImageTemplateName { get; set; }

    public string? SrimageTemplateType { get; set; }

    public string? Description { get; set; }

    public byte[]? Image { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
