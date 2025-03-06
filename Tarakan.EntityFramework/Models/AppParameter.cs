using System;

namespace Tarakan.EntityFramework.Models;

public partial class AppParameter
{   
    public string ParameterId { get; set; }

    public string ParameterName { get; set; }

    public string ParameterValue { get; set; }

    public string ParameterType { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool IsUsedBySystem { get; set; }

    public string Message { get; set; }
}
