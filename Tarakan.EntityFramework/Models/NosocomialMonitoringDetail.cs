using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NosocomialMonitoringDetail
{
    public string RegistrationNo { get; set; }

    public int MonitoringNo { get; set; }

    public int SequenceNo { get; set; }

    public DateTime? MonitoringDateTime { get; set; }

    public bool? IsChange01 { get; set; }

    public bool? IsChange02 { get; set; }

    public bool? IsChange03 { get; set; }

    public string Location { get; set; }

    public bool? IsTempAbove38 { get; set; }

    public bool? IsPain { get; set; }

    public bool? IsRedness { get; set; }

    public bool? IsFeelingHot { get; set; }

    public bool? IsSwollen { get; set; }

    public bool? IsPus { get; set; }

    public bool? IsKanulaCulture { get; set; }

    public bool? IsDisuria { get; set; }

    public bool? IsPyuria { get; set; }

    public bool? IsHematuria { get; set; }

    public bool? IsUrineCulture { get; set; }

    public bool? IsHeadache { get; set; }

    public bool? IsNoseClogged { get; set; }

    public bool? IsPainswallow { get; set; }

    public bool? IsPharingRedness { get; set; }

    public bool? IsCough { get; set; }

    public bool? IsTransillumination { get; set; }

    public bool? IsCulture { get; set; }

    public string Note { get; set; }

    public string ParamedicId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsDeleted { get; set; }
}
