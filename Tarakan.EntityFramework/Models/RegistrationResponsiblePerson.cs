using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationResponsiblePerson
{
    public string RegistrationNo { get; set; }

    public string NameOfTheResponsible { get; set; }

    public string Srrelationship { get; set; }

    public string Sroccupation { get; set; }

    public string HomeAddress { get; set; }

    public string PhoneNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string JobDescription { get; set; }

    public string Ssn { get; set; }

    public string OtherNameOfTheResponsibleTwo { get; set; }

    public string OtherSsnTwo { get; set; }

    public string SrrelationshipTwo { get; set; }
}
