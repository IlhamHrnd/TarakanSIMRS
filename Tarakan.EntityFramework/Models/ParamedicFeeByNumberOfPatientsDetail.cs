using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicFeeByNumberOfPatientsDetail
{
    public DateTime RegistrationDate { get; set; }

    public string ParamedicId { get; set; } = null!;

    public string RegistrationNo { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
