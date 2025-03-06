using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientMrnnameHistory
{
    public string PatientId { get; set; }

    public DateTime UpdateDateTime { get; set; }

    public string UpdateByUserId { get; set; }

    public string FromMedicalNo { get; set; }

    public string FromFirstName { get; set; }

    public string FromMiddleName { get; set; }

    public string FromLastName { get; set; }

    public string ToMedicalNo { get; set; }

    public string ToFirstName { get; set; }

    public string ToMiddleName { get; set; }

    public string ToLastName { get; set; }
}
