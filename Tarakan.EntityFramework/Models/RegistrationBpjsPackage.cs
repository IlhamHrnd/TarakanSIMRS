using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationBpjsPackage
{
    public string RegistrationNo { get; set; } = null!;

    public string PackageId { get; set; } = null!;

    public decimal Price { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
