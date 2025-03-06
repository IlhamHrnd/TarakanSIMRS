using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BedManagement
{
    public long BedManagementId { get; set; }

    public string BedId { get; set; }

    public DateTime TransactionDate { get; set; }

    public string PatientId { get; set; }

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

    public string MobilePhoneNo { get; set; }

    public string FaxNo { get; set; }

    public string Email { get; set; }

    public string ReservationNo { get; set; }

    public string RegistrationNo { get; set; }

    public string RegistrationBedId { get; set; }

    public string SrbedStatus { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string CreatedByUserId { get; set; }

    public bool? IsReleased { get; set; }

    public DateTime? ReleasedDateTime { get; set; }

    public string ReleasedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string VoidByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
