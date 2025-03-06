using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SmfDiagnose
{
    public string SmfId { get; set; }

    public string DiagnoseId { get; set; }

    public bool? IsVisible { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
