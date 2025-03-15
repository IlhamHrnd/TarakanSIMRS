using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationVisit
{
    public string RegistrationNo { get; set; } = null!;

    public int VisitNo { get; set; }

    public DateTime? VisitDateTime { get; set; }

    public string? VisitNotes { get; set; }

    public bool? IsDeleted { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? ServiceUnitId { get; set; }

    public string? RoomId { get; set; }

    public string? BedId { get; set; }
}
