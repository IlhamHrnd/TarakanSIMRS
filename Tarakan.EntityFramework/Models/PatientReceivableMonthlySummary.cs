using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientReceivableMonthlySummary
{
    public int Id { get; set; }

    public DateTime? Period { get; set; }

    public string? RegistrationNo { get; set; }

    public decimal? DownPayment { get; set; }

    public string? CreateByUserId { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public int? JournalId { get; set; }

    public bool? IsDischarged { get; set; }
}
