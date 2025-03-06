using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EncounterIh
{
    public string Id { get; set; }

    public string RegistrationNo { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string IdIhspatient { get; set; }
}
