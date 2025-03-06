using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Appointment
{
    public string AppointmentNo { get; set; }

    public int? AppointmentQue { get; set; }

    public string ServiceUnitId { get; set; }

    public string ParamedicId { get; set; }

    public string PatientId { get; set; }

    public DateTime AppointmentDate { get; set; }

    public string AppointmentTime { get; set; }

    public string VisitTypeId { get; set; }

    public byte VisitDuration { get; set; }

    public string SrappointmentStatus { get; set; }

    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    public string LastName { get; set; }

    public string StreetName { get; set; }

    public string District { get; set; }

    public string City { get; set; }

    public string County { get; set; }

    public string State { get; set; }

    public string ZipCode { get; set; }

    public string PhoneNo { get; set; }

    public string FaxNo { get; set; }

    public string Email { get; set; }

    public string MobilePhoneNo { get; set; }

    public string Notes { get; set; }

    public string PatientPic { get; set; }

    public string OfficerPic { get; set; }

    public DateTime? FollowUpDateTime { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? LastCreateDateTime { get; set; }

    public string LastCreateByUserId { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string GuarantorId { get; set; }

    public string FromRegistrationNo { get; set; }

    public string EmployeeNo { get; set; }

    public string EmployeeJobTitleName { get; set; }

    public string EmployeeJobDepartementName { get; set; }

    public string Sex { get; set; }

    public string BirthPlace { get; set; }

    public string Ssn { get; set; }

    public string Srsalutation { get; set; }

    public string Srnationality { get; set; }

    public string Sroccupation { get; set; }

    public string SrmaritalStatus { get; set; }

    public string ItemId { get; set; }

    public string SrreferralGroup { get; set; }

    public string ReferralName { get; set; }

    public string GuarantorCardNo { get; set; }

    public string ReferenceNumber { get; set; }

    public int? ReferenceType { get; set; }

    public string CancelNotes { get; set; }

    public string SrappoinmentType { get; set; }
}
