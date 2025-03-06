using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Customer
{
    public string CustomerId { get; set; }

    public string CustomerName { get; set; }

    public string ContactPerson { get; set; }

    public bool IsActive { get; set; }

    public string StreetName { get; set; }

    public string District { get; set; }

    public string City { get; set; }

    public string County { get; set; }

    public string State { get; set; }

    public string ZipCode { get; set; }

    public string PhoneNo { get; set; }

    public string FaxNo { get; set; }

    public string Email { get; set; }

    public string MobilePhoneNo { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public decimal? SalesMarginPercentage { get; set; }

    public int? ChartOfAccountIdAr { get; set; }

    public int? SubledgerIdAr { get; set; }

    public int? ChartOfAccountIdArtemporary { get; set; }

    public int? SubledgerIdArtemporary { get; set; }
}
