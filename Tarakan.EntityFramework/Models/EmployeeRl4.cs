using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeRl4
{
    public int EmployeeRl4id { get; set; }

    public int PersonId { get; set; }

    public int CompanyEducationProfileId { get; set; }

    public int CompanyFieldOfWorkProfileId { get; set; }

    public string Srrl4status { get; set; }

    public string Srrl4type { get; set; }

    public string SrmedisType { get; set; }

    public string SreducationLevel { get; set; }

    public int Rl4educationId { get; set; }

    public bool IsActive { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string Srrl4professionType { get; set; }

    public string Srrl4educationLevel { get; set; }

    public string Srrl4educationMajor { get; set; }
}
