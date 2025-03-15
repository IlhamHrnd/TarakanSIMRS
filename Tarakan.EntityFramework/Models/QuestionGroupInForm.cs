using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class QuestionGroupInForm
{
    public string QuestionFormId { get; set; } = null!;

    public string QuestionGroupId { get; set; } = null!;

    public int RowIndex { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
