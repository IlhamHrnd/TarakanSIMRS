using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RunQueryScript
{
    public int ScriptId { get; set; }

    public short Type { get; set; }

    public string Name { get; set; }

    public string ScriptText { get; set; }
}
