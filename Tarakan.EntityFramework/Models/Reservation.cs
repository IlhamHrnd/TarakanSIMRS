using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Reservation
{
    public string ReservationNo { get; set; } = null!;

    public DateTime ReservationDate { get; set; }

    public string PatientId { get; set; } = null!;

    public string? DepartmentId { get; set; }

    public string? ServiceUnitId { get; set; }

    public string? RoomId { get; set; }

    public string? ClassId { get; set; }

    public string BedId { get; set; } = null!;

    public string SrreservationStatus { get; set; } = null!;

    public DateTime? FollowUpDateTime { get; set; }

    public string? FollowUpByUserId { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? StreetName { get; set; }

    public string? District { get; set; }

    public string? City { get; set; }

    public string? County { get; set; }

    public string? State { get; set; }

    public string? ZipCode { get; set; }

    public string? PhoneNo { get; set; }

    public string? MobilePhoneNo { get; set; }

    public string? FaxNo { get; set; }

    public string? Email { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? RegistrationNo { get; set; }

    public string? FromServiceUnitId { get; set; }

    public string? FromRoomId { get; set; }

    public string? FromBedId { get; set; }

    public bool? IsDeleted { get; set; }
}
