﻿using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RepositoryInfo
{
    public string Name { get; set; } = null!;

    public int? InternalValue { get; set; }

    public string? CharacterValue { get; set; }
}
