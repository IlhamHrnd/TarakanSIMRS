using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeFormTemplate
{
    public int TemplateId { get; set; }

    public string TemplateName { get; set; }

    public string Result { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
