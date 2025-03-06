using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SubSpecialty
{
    public string SubSpecialtyId { get; set; }

    public string Srspecialty { get; set; }

    public string SubSpecialtyName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
