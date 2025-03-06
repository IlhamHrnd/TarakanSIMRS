using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SalaryTemplate
{
    public string SalaryTemplateId { get; set; }

    public string SalaryTemplateName { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
