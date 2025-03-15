using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientAllergy
{
    public string AllergyGroup { get; set; } = null!;

    public string Allergen { get; set; } = null!;

    public string AllergenName { get; set; } = null!;

    public string Sranaphylaxis { get; set; } = null!;

    public string Anaphylaxis { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string PatientId { get; set; } = null!;

    public string DescAndReaction { get; set; } = null!;
}
