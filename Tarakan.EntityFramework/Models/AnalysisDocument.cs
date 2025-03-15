using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AnalysisDocument
{
    public string RegistrationNo { get; set; } = null!;

    public string SrfilesAnalysis { get; set; } = null!;

    public DateTime FilesReceiveDate { get; set; }

    public DateTime? FilesAcceptanceDate { get; set; }

    public string ParamedicId { get; set; } = null!;

    public string? SrcompleteStatusRm { get; set; }

    public string? Notes { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
