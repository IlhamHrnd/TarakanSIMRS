using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicSoaptemplate
{
    public string ParamedicId { get; set; } = null!;

    public string SrmedicalNotesInputType { get; set; } = null!;

    public string SoaptemplateId { get; set; } = null!;

    public string? S { get; set; }

    public string? O { get; set; }

    public string? A { get; set; }

    public string? P { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastCreateDateTime { get; set; }

    public string? LastCreateByUserId { get; set; }
}
