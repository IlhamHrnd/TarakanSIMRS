using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Customer
{
    public string CustomerId { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string ContactPerson { get; set; } = null!;

    public bool IsActive { get; set; }

    public string StreetName { get; set; } = null!;

    public string? District { get; set; }

    public string City { get; set; } = null!;

    public string County { get; set; } = null!;

    public string State { get; set; } = null!;

    public string ZipCode { get; set; } = null!;

    public string PhoneNo { get; set; } = null!;

    public string FaxNo { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string MobilePhoneNo { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public decimal? SalesMarginPercentage { get; set; }

    public int? ChartOfAccountIdAr { get; set; }

    public int? SubledgerIdAr { get; set; }

    public int? ChartOfAccountIdArtemporary { get; set; }

    public int? SubledgerIdArtemporary { get; set; }
}
