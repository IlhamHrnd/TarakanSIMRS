using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationMrnhistory
{
    public string RegistrationNo { get; set; }

    public DateTime UpdateDateTime { get; set; }

    public string UpdateByUserId { get; set; }

    public string FromPatientId { get; set; }

    public string ToPatientId { get; set; }
}
