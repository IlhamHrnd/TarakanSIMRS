using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationCounselingLine
{
    public string RegistrationNo { get; set; }

    public int CounselingNo { get; set; }

    public string SrdrugCounseling { get; set; }

    public string Notes { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
