using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NutritionCareDiagnoseTransDt
{
    public long Id { get; set; }

    public string TransactionNo { get; set; }

    public string TerminologyId { get; set; }

    public string TerminologyName { get; set; }

    public string SrnutritionCareTerminologyLevel { get; set; }

    public string TerminologyParentId { get; set; }

    public string TmpTerminologyId { get; set; }

    public string TmpTerminologyParentId { get; set; }

    public long? ParentId { get; set; }

    public string ReferenceToPhrNo { get; set; }

    public string S { get; set; }

    public string O { get; set; }

    public string D { get; set; }

    public string I { get; set; }

    public string Me { get; set; }

    public DateTime? ExecuteDateTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }
}
