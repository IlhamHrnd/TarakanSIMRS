using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpQuePoli
{
    public DateOnly? RegistrationDate { get; set; }

    public int? LocationId { get; set; }

    public string ServiceUnitId { get; set; }

    public string QueueName { get; set; }

    public string ParamedicId { get; set; }

    public string ParamedicName { get; set; }

    public int? TotalNumber { get; set; }

    public int? LastNumber { get; set; }

    public int? LastRoom { get; set; }

    public int? CallNumber { get; set; }

    public int? CallRoom { get; set; }

    public string CallRegNo { get; set; }

    public int? RecallNumber { get; set; }

    public int? RecallRoom { get; set; }

    public string RecallRegNo { get; set; }
}
