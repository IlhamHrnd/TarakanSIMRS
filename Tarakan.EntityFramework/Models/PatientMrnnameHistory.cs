using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientMrnnameHistory
{
    public string PatientId { get; set; } = null!;

    public DateTime UpdateDateTime { get; set; }

    public string UpdateByUserId { get; set; } = null!;

    public string FromMedicalNo { get; set; } = null!;

    public string FromFirstName { get; set; } = null!;

    public string FromMiddleName { get; set; } = null!;

    public string FromLastName { get; set; } = null!;

    public string ToMedicalNo { get; set; } = null!;

    public string ToFirstName { get; set; } = null!;

    public string ToMiddleName { get; set; } = null!;

    public string ToLastName { get; set; } = null!;
}
