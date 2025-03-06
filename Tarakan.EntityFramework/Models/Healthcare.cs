using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Healthcare
{
    public string HealthcareId { get; set; }

    public string HealthcareName { get; set; }

    public string AddressLine1 { get; set; }

    public string AddressLine2 { get; set; }

    public string City { get; set; }

    public string ZipCode { get; set; }

    public string PhoneNo { get; set; }

    public string FaxNo { get; set; }

    public string HospitalCode { get; set; }

    public string FoundationName { get; set; }

    public string FoundationAddr1 { get; set; }

    public string FoundationAddr2 { get; set; }

    public string FoundationCity { get; set; }

    public string FoundationZipCode { get; set; }

    public string FoundationPhoneNo { get; set; }

    public string FoundationFaxNo { get; set; }

    public string EmailAddr { get; set; }

    public string Website { get; set; }

    public string Npwp { get; set; }

    public string HospitalType { get; set; }

    public string Provinces { get; set; }

    public string ProvincesCode { get; set; }

    public string AdditionalInfo { get; set; }

    public byte[] HealthcareLogo { get; set; }
}
