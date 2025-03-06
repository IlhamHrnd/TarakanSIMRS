using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NursingDiagnosaTemplate
{
    public int TemplateId { get; set; }

    public string TemplateName { get; set; }

    public string TemplateText { get; set; }

    public bool IsActive { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }
}
