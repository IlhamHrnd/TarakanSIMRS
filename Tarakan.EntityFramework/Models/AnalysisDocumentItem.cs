using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AnalysisDocumentItem
{
    public string RegistrationNo { get; set; } = null!;

    public int DocumentFilesId { get; set; }

    public bool IsQuantity { get; set; }

    public bool IsQuality { get; set; }

    public bool IsLegible { get; set; }

    public bool IsSign { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
