using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SmfDiagnose
{
    public string SmfId { get; set; } = null!;

    public string DiagnoseId { get; set; } = null!;

    public bool? IsVisible { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
