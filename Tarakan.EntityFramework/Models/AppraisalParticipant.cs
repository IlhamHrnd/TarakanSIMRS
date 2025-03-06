using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppraisalParticipant
{
    public int ParticipantId { get; set; }

    public string ParticipantName { get; set; }

    public string PeriodYear { get; set; }

    public string Notes { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string VoidByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsScoringRecapitulation { get; set; }

    public string SrquarterPeriod { get; set; }
}
