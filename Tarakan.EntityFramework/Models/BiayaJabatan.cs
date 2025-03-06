using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BiayaJabatan
{
    public int BiayaJabatanId { get; set; }

    public DateTime ValidFrom { get; set; }

    public decimal AmountOfDeduction { get; set; }

    public decimal PercentOfDeduction { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
