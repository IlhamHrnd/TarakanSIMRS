using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Appointment
{
    public string AppointmentNo { get; set; } = null!;

    public int? AppointmentQue { get; set; }

    public string ServiceUnitId { get; set; } = null!;

    public string ParamedicId { get; set; } = null!;

    public string? PatientId { get; set; }

    public DateTime AppointmentDate { get; set; }

    public string? AppointmentTime { get; set; }

    public string VisitTypeId { get; set; } = null!;

    public byte VisitDuration { get; set; }

    public string SrappointmentStatus { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string StreetName { get; set; } = null!;

    public string District { get; set; } = null!;

    public string City { get; set; } = null!;

    public string County { get; set; } = null!;

    public string State { get; set; } = null!;

    public string? ZipCode { get; set; }

    public string PhoneNo { get; set; } = null!;

    public string FaxNo { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? MobilePhoneNo { get; set; }

    public string Notes { get; set; } = null!;

    public string? PatientPic { get; set; }

    public string? OfficerPic { get; set; }

    public DateTime? FollowUpDateTime { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastCreateDateTime { get; set; }

    public string? LastCreateByUserId { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? GuarantorId { get; set; }

    public string? FromRegistrationNo { get; set; }

    public string? EmployeeNo { get; set; }

    public string? EmployeeJobTitleName { get; set; }

    public string? EmployeeJobDepartementName { get; set; }

    public string? Sex { get; set; }

    public string? BirthPlace { get; set; }

    public string? Ssn { get; set; }

    public string? Srsalutation { get; set; }

    public string? Srnationality { get; set; }

    public string? Sroccupation { get; set; }

    public string? SrmaritalStatus { get; set; }

    public string? ItemId { get; set; }

    public string? SrreferralGroup { get; set; }

    public string? ReferralName { get; set; }

    public string? GuarantorCardNo { get; set; }

    public string? ReferenceNumber { get; set; }

    public int? ReferenceType { get; set; }

    public string? CancelNotes { get; set; }

    public string? SrappoinmentType { get; set; }
}
