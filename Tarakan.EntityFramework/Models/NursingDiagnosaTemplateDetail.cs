using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NursingDiagnosaTemplateDetail
{
    public int TemplateId { get; set; }

    public string QuestionId { get; set; } = null!;

    public string CreateByUserId { get; set; } = null!;

    public DateTime? CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public int? RowIndex { get; set; }
}
