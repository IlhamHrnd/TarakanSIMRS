using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SalaryTemplateItem
{
    public string SalaryTemplateId { get; set; }

    public int SalaryComponentId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
