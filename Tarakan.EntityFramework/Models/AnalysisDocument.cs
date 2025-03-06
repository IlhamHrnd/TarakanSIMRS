using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AnalysisDocument
{
    public string RegistrationNo { get; set; }

    public string SrfilesAnalysis { get; set; }

    public DateTime FilesReceiveDate { get; set; }

    public DateTime? FilesAcceptanceDate { get; set; }

    public string ParamedicId { get; set; }

    public string SrcompleteStatusRm { get; set; }

    public string Notes { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
