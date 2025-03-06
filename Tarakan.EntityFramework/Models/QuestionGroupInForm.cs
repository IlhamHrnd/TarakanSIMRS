using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class QuestionGroupInForm
{
    public string QuestionFormId { get; set; }

    public string QuestionGroupId { get; set; }

    public int RowIndex { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
