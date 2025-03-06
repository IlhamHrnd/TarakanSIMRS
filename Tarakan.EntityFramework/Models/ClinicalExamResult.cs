using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ClinicalExamResult
{
    public string RegistrationNo { get; set; }

    public string ParamedicId { get; set; }

    public string Title { get; set; }

    public string Result { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
