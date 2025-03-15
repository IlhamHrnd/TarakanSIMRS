using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class K3rsForm
{
    public string TransactionNo { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public int TemplateId { get; set; }

    public string Notes { get; set; } = null!;

    public string? Result { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
