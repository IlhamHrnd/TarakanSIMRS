using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeLanguageProficiency
{
    public int EmployeeLanguageProficiencyId { get; set; }

    public int PersonId { get; set; }

    public DateTime EvaluationDate { get; set; }

    public string Srlanguage { get; set; }

    public string Srconversation { get; set; }

    public string Srtranslation { get; set; }

    public string Notes { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
