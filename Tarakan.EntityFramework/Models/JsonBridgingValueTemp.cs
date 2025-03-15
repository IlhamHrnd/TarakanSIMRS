using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class JsonBridgingValueTemp
{
    public string Id { get; set; } = null!;

    public string? JsonValue { get; set; }
}
