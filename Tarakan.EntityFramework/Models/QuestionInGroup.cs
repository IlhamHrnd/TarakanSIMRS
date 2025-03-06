using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class QuestionInGroup
{
    public string QuestionGroupId { get; set; }

    public string QuestionId { get; set; }

    public int RowIndex { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public int? PageNo { get; set; }

    public string ParentQuestionId { get; set; }

    public int? QuestionLevel { get; set; }
}
