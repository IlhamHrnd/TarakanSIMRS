using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class KTotalPayment
{
    public string RegistrationNo { get; set; }

    public decimal? Payment { get; set; }

    public string FirstName { get; set; }
}
