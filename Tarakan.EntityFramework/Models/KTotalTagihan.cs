using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class KTotalTagihan
{
    public string RegistrationNo { get; set; } = null!;

    public decimal? TotTagihan { get; set; }

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string LastName { get; set; } = null!;
}
