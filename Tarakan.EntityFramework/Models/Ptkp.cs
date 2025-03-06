using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Ptkp
{
    public int PtkpId { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public string SrtaxStatus { get; set; }

    public decimal Amount { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
