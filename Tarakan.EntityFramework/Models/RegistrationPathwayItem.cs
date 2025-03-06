using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationPathwayItem
{
    public string RegistrationNo { get; set; }

    public string PathwayId { get; set; }

    public int PathwayItemSeqNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
