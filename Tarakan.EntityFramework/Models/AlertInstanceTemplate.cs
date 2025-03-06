using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AlertInstanceTemplate
{
    public int Id { get; set; }

    public int? SqlserverId { get; set; }

    public int? TemplateId { get; set; }
}
