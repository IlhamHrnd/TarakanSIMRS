using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Bed
{
    public string BedId { get; set; }

    public string RoomId { get; set; }

    public string RegistrationNo { get; set; }

    public string ClassId { get; set; }

    public string SrbedStatus { get; set; }

    public string BedStatusUpdatedBy { get; set; }

    public bool IsTemporary { get; set; }

    public bool IsActive { get; set; }

    public bool? IsNeedConfirmation { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsRoomIn { get; set; }

    public DateTime? BookingDateTime { get; set; }

    public bool? IsVisibleTo3rdParty { get; set; }

    public string OldBedId { get; set; }

    public string DefaultChargeClassId { get; set; }

    public string Notes { get; set; }
}
