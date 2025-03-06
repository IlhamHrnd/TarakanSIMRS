using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PpiRiskFactorsItem
{
    public string RegistrationNo { get; set; }

    public string SequenceNo { get; set; }

    public DateTime DateOfInfection { get; set; }

    public string SrsignsOfInfection { get; set; }

    public string Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
