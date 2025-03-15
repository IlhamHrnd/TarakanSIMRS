using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BornCertification
{
    public string BornCertificationNumber { get; set; } = null!;

    public string BabyName { get; set; } = null!;

    public string? MotherName { get; set; }

    public string? FatherName { get; set; }

    public string? Address { get; set; }

    public DateTime? BornDate { get; set; }

    public double? BodyLength { get; set; }

    public double? BodyWeight { get; set; }

    public string? Gender { get; set; }

    public int? IsNormal { get; set; }

    public string? BornAct { get; set; }

    public string? CongenitalDisorder { get; set; }

    public int? Twins { get; set; }

    public int? ChildNumber { get; set; }

    public string? HelpBy { get; set; }

    public DateOnly? PrintDate { get; set; }
}
