using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Referral
{
    public string ReferralId { get; set; }

    public string ReferralName { get; set; }

    public string ShortName { get; set; }

    public string DepartmentName { get; set; }

    public string SrreferralGroup { get; set; }

    public string TaxRegistrationNo { get; set; }

    public bool IsPkp { get; set; }

    public string TermId { get; set; }

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

    public bool IsRefferalFrom { get; set; }

    public bool IsRefferalTo { get; set; }

    public bool IsActive { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string ParamedicId { get; set; }
}
