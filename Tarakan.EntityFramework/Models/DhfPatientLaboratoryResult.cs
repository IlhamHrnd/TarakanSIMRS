using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class DhfPatientLaboratoryResult
{
    public string RegistrationNo { get; set; }

    public short? Days { get; set; }

    public decimal? Leukosit { get; set; }

    public decimal? Trombosit { get; set; }

    public decimal? Hematokrit { get; set; }

    public decimal? Hemoglobin { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
