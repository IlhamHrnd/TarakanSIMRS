using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicFeeRemunByIdiSummary
{
    public int RemunId { get; set; }

    public string ParamedicId { get; set; }

    public int CoorporateGradeLevel { get; set; }

    public int CoorporateGradeValue { get; set; }

    public decimal CoefficientSummary { get; set; }

    public decimal ProcedureFeeValue { get; set; }

    public decimal PositionFeeValue { get; set; }

    public decimal InsentifFeeValue { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
