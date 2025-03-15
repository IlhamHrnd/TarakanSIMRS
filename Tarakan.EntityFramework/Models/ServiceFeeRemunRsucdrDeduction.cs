using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ServiceFeeRemunRsucdrDeduction
{
    public int RemunId { get; set; }

    public string SrremunDeduction { get; set; } = null!;

    public decimal Amount { get; set; }

    public string CreateByUserId { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }
}
