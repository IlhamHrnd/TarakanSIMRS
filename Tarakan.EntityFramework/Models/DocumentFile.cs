using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DocumentFile
{
    public int DocumentFilesId { get; set; }

    public string DocumentName { get; set; }

    public string DocumentNumber { get; set; }

    public string FileTemplateName { get; set; }

    public bool IsQuality { get; set; }

    public bool IsLegible { get; set; }

    public bool IsSign { get; set; }

    public bool? IsActive { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsUsedForAnalysis { get; set; }

    public bool? IsUsedForGuarantorChecklist { get; set; }

    public string ProgramId { get; set; }
}
