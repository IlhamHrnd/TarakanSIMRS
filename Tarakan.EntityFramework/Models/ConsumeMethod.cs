using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ConsumeMethod
{
    public string SrconsumeMethod { get; set; }

    public string SrconsumeMethodName { get; set; }

    public string TimeSequence { get; set; }

    public DateTime? LastCreateDateTime { get; set; }

    public string LastCreateByUserId { get; set; }

    public string SygnaText { get; set; }

    public int? IterationQty { get; set; }

    public string IterationInInterval { get; set; }

    public string Time01 { get; set; }

    public string Time02 { get; set; }

    public string Time03 { get; set; }

    public string Time04 { get; set; }

    public string Time05 { get; set; }

    public string Time06 { get; set; }

    public string Time07 { get; set; }

    public string Time08 { get; set; }

    public string Time09 { get; set; }

    public string Time10 { get; set; }

    public bool? IsActive { get; set; }

    public int? LineNumber { get; set; }
}
