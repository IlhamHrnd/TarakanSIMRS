using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Pio
{
    public int PioNo { get; set; }

    public DateTime? PioDateTime { get; set; }

    public string? QuestionerName { get; set; }

    public string? Sroccupation { get; set; }

    public string? Question { get; set; }

    public string? Information { get; set; }

    public string? OtherSources { get; set; }

    public string? OtherCategory { get; set; }

    public bool? IsDeleted { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? SrdurationType { get; set; }

    public bool? IsInternRecipient { get; set; }

    public string? SranswerMethod { get; set; }

    public string? SrquestionMethod { get; set; }

    public DateTime? AnswerDateTime { get; set; }

    public string? ServiceUnitId { get; set; }
}
