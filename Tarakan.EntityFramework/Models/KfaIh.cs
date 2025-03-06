using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class KfaIh
{
    public string KdVaktual { get; set; }

    public string NameVaktual { get; set; }

    public string KdVtemplate { get; set; }

    public string NameVtemplate { get; set; }

    public string KdVingredients { get; set; }

    public string NameIngredient { get; set; }

    public string Dosis { get; set; }

    public string Satuan { get; set; }

    public string Bagi { get; set; }

    public string IdItem { get; set; }
}
