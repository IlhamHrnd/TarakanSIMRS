namespace Tarakan.EntityFramework.Models;

public partial class PatientAllergy
{
    public string AllergyGroup { get; set; }

    public string Allergen { get; set; }

    public string AllergenName { get; set; }

    public string Sranaphylaxis { get; set; }

    public string Anaphylaxis { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string PatientId { get; set; }

    public string DescAndReaction { get; set; }
}
