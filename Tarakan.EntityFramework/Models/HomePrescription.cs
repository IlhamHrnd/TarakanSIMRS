using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class HomePrescription
{
    public long MedicationReceiveNo { get; set; }

    public string? Morning { get; set; }

    public string? Noon { get; set; }

    public string? Afternoon { get; set; }

    public string? Night { get; set; }

    public string? Note { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? DrugName { get; set; }

    public string? Indication { get; set; }
}
