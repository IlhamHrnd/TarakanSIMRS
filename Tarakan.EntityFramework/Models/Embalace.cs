using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Embalace
{
    public string EmbalaceId { get; set; }

    public string EmbalaceName { get; set; }

    public string EmbalaceLabel { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public decimal? EmbalaceFeeAmount { get; set; }
}
