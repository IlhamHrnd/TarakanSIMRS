using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationDrugObsItem
{
    public string RegistrationNo { get; set; }

    public int DrugObsNo { get; set; }

    public long MedicationReceiveNo { get; set; }

    public string FollowUp { get; set; }

    public string Notes { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
