using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class LocationTemplate
{
    public string TemplateNo { get; set; }

    public string TemplateName { get; set; }

    public string LocationId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
