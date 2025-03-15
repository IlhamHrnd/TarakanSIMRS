using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class QueueingSound
{
    public int SoundId { get; set; }

    public string Name { get; set; } = null!;

    public int? Number { get; set; }

    public string FilePath { get; set; } = null!;

    public string CreateByUserId { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public bool? IsServiceCounter { get; set; }
}
