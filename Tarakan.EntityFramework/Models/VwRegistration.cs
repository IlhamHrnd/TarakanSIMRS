using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwRegistration
{
    public string RegistrationNo { get; set; }

    public string ParamedicId { get; set; }

    public string GuarantorId { get; set; }

    public string PatientId { get; set; }

    public DateTime RegistrationDate { get; set; }

    public string RegistrationTime { get; set; }

    public byte AgeInYear { get; set; }

    public byte AgeInMonth { get; set; }

    public byte AgeInDay { get; set; }

    public string ServiceUnitId { get; set; }

    public string RoomId { get; set; }

    public string BedId { get; set; }

    public string VisitTypeId { get; set; }

    public string Anamnesis { get; set; }

    public string Complaint { get; set; }

    public string InitialDiagnose { get; set; }

    public string MedicationPlanning { get; set; }
}
