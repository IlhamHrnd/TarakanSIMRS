using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DocumentDefinition
{
    public int DocumentDefinitionId { get; set; }

    public string DepartmentId { get; set; } = null!;

    public string SrfilesAnalysis { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
