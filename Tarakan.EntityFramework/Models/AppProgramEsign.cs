using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppProgramEsign
{
    public string ProgramId { get; set; }

    public bool? IsVisible { get; set; }

    public string TagCoordinate { get; set; }

    public string Page { get; set; }

    public int? Xaxis { get; set; }

    public int? Yaxis { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }

    public string UrlRootHist { get; set; }
}
