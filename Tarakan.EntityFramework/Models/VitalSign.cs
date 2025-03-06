using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VitalSign
{
    public string VitalSignId { get; set; }

    public string VitalSignName { get; set; }

    public string VitalSignInitial { get; set; }

    public string SrvitalSignGroup { get; set; }

    public int? RowIndexInGroup { get; set; }

    public string ValueType { get; set; }

    public string StandardReferenceId { get; set; }

    public string EntryMask { get; set; }

    public string VitalSignUnit { get; set; }

    public string NumType { get; set; }

    public int? NumDecimalDigits { get; set; }

    public int? NumMinValue { get; set; }

    public int? NumMaxValue { get; set; }

    public int? NumMaxLength { get; set; }

    public bool? IsMonitoring { get; set; }

    public bool? IsChart { get; set; }

    public int? ChartColor { get; set; }

    public int? ChartMinValue { get; set; }

    public int? ChartMaxValue { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    /// <summary>
    /// Untuk keperluan import data dari PHR
    /// </summary>
    public string QuestionId { get; set; }

    public string ParentVitalSignId { get; set; }
}
