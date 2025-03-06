using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Therapy
{
    public string TherapyId { get; set; }

    public string TherapyName { get; set; }

    public string SrtherapyGroup { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
