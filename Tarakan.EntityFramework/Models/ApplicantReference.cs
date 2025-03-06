using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ApplicantReference
{
    public int ApplicantReferencesId { get; set; }

    public int ApplicantId { get; set; }

    public string ReferencesName { get; set; }

    public string Relationship { get; set; }

    public string OrganizationName { get; set; }

    public string JobTitle { get; set; }

    public string Address { get; set; }

    public string Phone { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
