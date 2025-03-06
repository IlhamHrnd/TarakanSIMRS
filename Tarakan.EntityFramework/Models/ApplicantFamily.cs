using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ApplicantFamily
{
    public int ApplicantFamilyId { get; set; }

    public int ApplicantId { get; set; }

    public string SrfamilyRelation { get; set; }

    public string FamilyName { get; set; }

    public DateTime DateBirth { get; set; }

    public string SreducationLevel { get; set; }

    public string Address { get; set; }

    public string SrmaritalStatus { get; set; }

    public string SrgenderType { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
