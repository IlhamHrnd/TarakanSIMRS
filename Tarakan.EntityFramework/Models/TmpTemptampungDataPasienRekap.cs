using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpTemptampungDataPasienRekap
{
    public string? RegistrationNo { get; set; }

    public string? RegistrationNoIgd { get; set; }

    public string? GuarantorId { get; set; }

    public string? PatientId { get; set; }

    public string? ServiceUnitId { get; set; }

    public string? RoomId { get; set; }

    public string? UserId { get; set; }

    public DateTime? TimeStamp { get; set; }
}
