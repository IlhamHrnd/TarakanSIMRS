using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ReferExternalBak
{
    public string RegistrationNo { get; set; }

    public string ReferralId { get; set; }

    public string SrreferReason { get; set; }

    public string ReferReasonOther { get; set; }

    public string OtherInformation { get; set; }

    public string ReferralAgreedBy { get; set; }

    public DateTime? ReferralAgreedTime { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
