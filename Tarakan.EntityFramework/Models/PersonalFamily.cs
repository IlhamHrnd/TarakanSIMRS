using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PersonalFamily
{
    public int PersonalFamilyId { get; set; }

    public int PersonId { get; set; }

    public string PatientId { get; set; }

    public string SrfamilyRelation { get; set; }

    public string FamilyName { get; set; }

    public string CityOfBirth { get; set; }

    public DateTime DateBirth { get; set; }

    public string SreducationLevel { get; set; }

    public string Address { get; set; }

    public string Srstate { get; set; }

    public string Srcity { get; set; }

    public string ZipCode { get; set; }

    public string Phone { get; set; }

    public string SrmaritalStatus { get; set; }

    public string SrgenderType { get; set; }

    public bool? IsGuaranteed { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string SrcoverageType { get; set; }

    public string BpjskesehatanNo { get; set; }

    public string District { get; set; }

    public string County { get; set; }

    public string City { get; set; }

    public DateTime? WeddingDate { get; set; }

    public string SrfamilyOccupation { get; set; }
}
