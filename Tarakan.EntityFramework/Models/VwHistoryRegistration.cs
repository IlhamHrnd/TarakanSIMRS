using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwHistoryRegistration
{
    public string RegistrationNo { get; set; }

    public string AppointmentNo { get; set; }

    public string ParamedicId { get; set; }

    public string PatientId { get; set; }

    public string MedicalNo { get; set; }

    public string PatientName { get; set; }

    public string ParamedicName { get; set; }

    public string ParamedicInitial { get; set; }

    public DateTime RegistrationDate { get; set; }

    public string RegistrationTime { get; set; }

    public string LastCreateUserId { get; set; }

    public string GuarantorName { get; set; }

    public string ServiceUnitName { get; set; }

    public string AppointmentTimeConvert { get; set; }

    public string Weekdays { get; set; }

    public string Notes { get; set; }

    public int? RegistrationQue { get; set; }
}
