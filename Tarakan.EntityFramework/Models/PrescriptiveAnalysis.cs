using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PrescriptiveAnalysis
{
    public int AnalysisId { get; set; }

    public int SqlserverId { get; set; }

    public DateTime? UtcanalysisStartTime { get; set; }

    public DateTime? UtcanalysisCompleteTime { get; set; }

    public int? RecommendationCount { get; set; }

    public int AnalysisTypeId { get; set; }

    public DateTime? RecordCreatedTimestamp { get; set; }

    public DateTime? RecordUpdateDateTimestamp { get; set; }

    public virtual PrescriptiveAnalysisType AnalysisType { get; set; }

    public virtual ICollection<PrescriptiveAnalysisDetail> PrescriptiveAnalysisDetails { get; set; } = new List<PrescriptiveAnalysisDetail>();
}
