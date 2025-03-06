using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemLaboratoryDetail
{
    public string ItemId { get; set; }

    public string SequenceNo { get; set; }

    public string Sex { get; set; }

    public string SrageUnit { get; set; }

    public decimal? AgeMin { get; set; }

    public decimal? AgeMax { get; set; }

    public string SranswerType { get; set; }

    public string NormalValueMin { get; set; }

    public string NormalValueMax { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public decimal? TotalAgeMin { get; set; }

    public decimal? TotalAgeMax { get; set; }

    public string Notes { get; set; }

    public string AnswerTypeReferenceId { get; set; }
}
