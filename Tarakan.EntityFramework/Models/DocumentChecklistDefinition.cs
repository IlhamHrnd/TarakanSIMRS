using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DocumentChecklistDefinition
{
    public string SrdocumentChecklist { get; set; }

    public int DocumentFilesId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
