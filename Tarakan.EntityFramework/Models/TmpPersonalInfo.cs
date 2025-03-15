using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpPersonalInfo
{
    public int? PersonId { get; set; }

    public string? EmployeeNumber { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? PreTitle { get; set; }

    public string? PostTitle { get; set; }

    public string? BirthName { get; set; }

    public string? PlaceBirth { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? SrgenderType { get; set; }

    public string? Srreligion { get; set; }

    public string? Srsalutation { get; set; }

    public string? SrbloodType { get; set; }

    public string? SrmaritalStatus { get; set; }

    public string? Picture { get; set; }

    public string? PatientId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? CoverageClass { get; set; }

    public string? CoverageClassBpjs { get; set; }

    public string? Srethnic { get; set; }
}
