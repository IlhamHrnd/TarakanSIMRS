using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientFluidBalanceSchemaInfu
{
    public string RegistrationNo { get; set; }

    public int SequenceNo { get; set; }

    public int SchemaInfusNo { get; set; }

    public string SchemaInfusName { get; set; }

    public int QtyVolume { get; set; }

    public int QtyPerHour { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
