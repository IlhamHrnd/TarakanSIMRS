using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BakTr115sheet1
{
    public string ReferenceNo { get; set; }

    public string StartingDate { get; set; }

    public string SrtariffType { get; set; }

    public string TariffTypeName { get; set; }

    public string ItemGroupId { get; set; }

    public string ItemGroupName { get; set; }

    public string ItemId { get; set; }

    public string ItemName { get; set; }

    public string ClassId { get; set; }

    public string ClassName { get; set; }

    public string TariffComponentId { get; set; }

    public string TariffComponentName { get; set; }

    public double? GeneralPrice { get; set; }

    public double? OldPrice { get; set; }

    public double? NewPrice { get; set; }
}
