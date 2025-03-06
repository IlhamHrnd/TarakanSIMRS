using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class LocationException
{
    public string LocationId { get; set; }

    public string LocationExceptionId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
