using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EdcmachineTariff
{
    public string EdcmachineId { get; set; } = null!;

    /// <summary>
    /// Visa, master, diner
    /// </summary>
    public string SrcardType { get; set; } = null!;

    public decimal EdcmachineTariff1 { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public bool? IsChargedToPatient { get; set; }

    public int? ChartOfAccountId { get; set; }

    public int? SubledgerId { get; set; }

    public virtual Edcmachine Edcmachine { get; set; } = null!;
}
