using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientOtp
{
    public string PatientId { get; set; }

    public string OtpCode { get; set; }

    public DateTime? OtpCreatedDate { get; set; }

    public string LastCreatedByUserId { get; set; }

    public byte AttempCount { get; set; }

    public bool IsValidatedPhone { get; set; }

    public string LastWhatsappSendLogId { get; set; }
}
