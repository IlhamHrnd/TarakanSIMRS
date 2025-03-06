using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BloodReceivedItem
{
    public string TransactionNo { get; set; }

    public string BagNo { get; set; }

    public string SrbloodType { get; set; }

    public string BloodRhesus { get; set; }

    public string SrbloodGroup { get; set; }

    public DateTime? ExpiredDateTime { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public decimal? VolumeBag { get; set; }
}
