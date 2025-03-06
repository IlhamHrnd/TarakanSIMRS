using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppProgramHealthcare
{
    public string ProgramId { get; set; }

    public string HealthcareInitial { get; set; }

    public string NavigateUrl { get; set; }

    public string AssemblyName { get; set; }

    public string AssemblyClassName { get; set; }

    public string StoreProcedureName { get; set; }

    public string ProgramType { get; set; }

    public bool? IsUsingReportHeader { get; set; }

    public bool? IsDirectPrintEnable { get; set; }

    public string HelpLinkId { get; set; }

    public string HealthcareId { get; set; }
}
