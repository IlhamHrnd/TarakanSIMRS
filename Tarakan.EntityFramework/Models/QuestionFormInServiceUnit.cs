using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class QuestionFormInServiceUnit
{
    public string ServiceUnitId { get; set; }

    public string QuestionFormId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
