using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Snack
{
    public string SnackId { get; set; }

    public string SnackName { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
