using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BodyDiagram
{
    public string BodyId { get; set; } = null!;

    public string? BodyName { get; set; }

    public string? Description { get; set; }

    public byte[]? BodyImage { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
