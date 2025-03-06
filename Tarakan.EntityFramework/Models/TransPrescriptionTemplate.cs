using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPrescriptionTemplate
{
    public string TemplateNo { get; set; }

    public string TemplateName { get; set; }

    public string ParamedicId { get; set; }

    public DateTime LastCreateDateTime { get; set; }

    public string LastCreateUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
