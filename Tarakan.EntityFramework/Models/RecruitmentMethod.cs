using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RecruitmentMethod
{
    public int RecruitmentMethodId { get; set; }

    public int PersonnelRequisitionId { get; set; }

    public string SrrecruitmentMethod { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
