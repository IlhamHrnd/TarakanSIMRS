using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BedRoomIn
{
    public string BedId { get; set; }

    public string RegistrationNo { get; set; }

    public DateTime DateOfEntry { get; set; }

    public string TimeOfEntry { get; set; }

    public DateTime? DateOfExit { get; set; }

    public string TimeOfExit { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string SrbedStatus { get; set; }

    public string BedStatusUpdatedBy { get; set; }
}
