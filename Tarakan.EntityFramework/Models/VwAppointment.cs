using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwAppointment
{
    public string AppointmentNo { get; set; }

    public string ParamedicId { get; set; }

    public string MedicalNo { get; set; }

    public string PatientName { get; set; }

    public string MobilePhoneNo { get; set; }

    public string ParamedicName { get; set; }

    public string ParamedicInitial { get; set; }

    public DateTime AppointmentDate { get; set; }

    public string AppointmentTime { get; set; }

    public string AppointmentTimeConvert { get; set; }

    public int? AppointmentQue { get; set; }

    public string Weekdays { get; set; }

    public string Notes { get; set; }
}
