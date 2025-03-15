using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientEducationRsudt
{
    public string RegistrationNo { get; set; } = null!;

    public string SreducationGivenTo { get; set; } = null!;

    public string EducationGivenToExtraText { get; set; } = null!;

    public string Age { get; set; } = null!;

    public string SreducationLanguage { get; set; } = null!;

    public string LanguageExtraText { get; set; } = null!;

    public string SreducationTranslatorNeeded { get; set; } = null!;

    public string TranslatorExtraText { get; set; } = null!;

    public string SreducationEthnic { get; set; } = null!;

    public string EthicExtraText { get; set; } = null!;

    public string Srreligion { get; set; } = null!;

    public string SrbeliefValue { get; set; } = null!;

    public string BeliefValueExtraText { get; set; } = null!;

    public string SremotionalProblem { get; set; } = null!;

    public string Sreducation { get; set; } = null!;

    public string SrinformationWillingToAccept { get; set; } = null!;

    public string SreducationProcedure { get; set; } = null!;

    public string SreducationTherapy { get; set; } = null!;

    public string SreducationRehabilitation { get; set; } = null!;

    public string SreducationCarePlan { get; set; } = null!;

    public string SreducationMedicalEquip { get; set; } = null!;

    public string SreducationMedicalSupport { get; set; } = null!;

    public string Others { get; set; } = null!;

    public string CreateByUserId { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public DateOnly? PlanDate { get; set; }
}
