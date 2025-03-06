using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Indication
{
    public string IndicationId { get; set; }

    public string IndicationName { get; set; }

    public bool IsActive { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public string InsertByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
