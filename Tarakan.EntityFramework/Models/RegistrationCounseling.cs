using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationCounseling
{
    public string RegistrationNo { get; set; } = null!;

    public int CounselingNo { get; set; }

    public DateTime? CounselingDateTime { get; set; }

    public string? CounselingNotes { get; set; }

    public bool? IsDeleted { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? ServiceUnitId { get; set; }

    public string? RoomId { get; set; }

    public string? BedId { get; set; }
}
