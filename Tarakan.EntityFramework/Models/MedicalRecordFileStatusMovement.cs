using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MedicalRecordFileStatusMovement
{
    public string RegistrationNo { get; set; }

    public string LastPositionServiceUnitId { get; set; }

    public DateTime? LastPositionDateTime { get; set; }

    public string LastPositionUserId { get; set; }
}
