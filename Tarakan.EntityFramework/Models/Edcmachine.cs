using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Edcmachine
{
    public string EdcmachineId { get; set; }

    /// <summary>
    /// Lippo, BCA, BNI
    /// </summary>
    public string SrcardProvider { get; set; }

    public string EdcmachineName { get; set; }

    public bool IsActive { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public int? ChartOfAccountId { get; set; }

    public int? SubledgerId { get; set; }

    public virtual ICollection<EdcmachineTariff> EdcmachineTariffs { get; set; } = new List<EdcmachineTariff>();
}
