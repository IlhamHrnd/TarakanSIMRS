using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DocumentDefinition
{
    public int DocumentDefinitionId { get; set; }

    public string DepartmentId { get; set; }

    public string SrfilesAnalysis { get; set; }

    public bool IsActive { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
