using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppointmentLokadok
{
    public long ApptId { get; set; }

    public long? StartDate { get; set; }

    public long? EndDate { get; set; }

    public int? Place { get; set; }

    public string? PId { get; set; }

    public string? PName { get; set; }

    public long? PDob { get; set; }

    public string? PGender { get; set; }

    public string? PMobile { get; set; }

    public string? PInsurance { get; set; }

    public string? PInsId { get; set; }

    public string? PInsNumber { get; set; }

    public string? LkdPid { get; set; }

    public string? DocId { get; set; }

    public string? Doctor { get; set; }

    public string? DocSpc { get; set; }

    public string? PolyId { get; set; }

    public string? Notes { get; set; }

    public string? ReasonVisit { get; set; }

    public string? Confirmed { get; set; }

    public string? CheckedIn { get; set; }

    public bool? NewPatient { get; set; }

    public string? BookingCode { get; set; }

    public string? Status { get; set; }

    public string? RegistrationNo { get; set; }

    public string? RegistrationNoSender { get; set; }
}
