using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPrescriptionFloorSeqNo
{
    public DateTime PrescriptionDate { get; set; }

    public string Srfloor { get; set; } = null!;

    public string ServiceUnitId { get; set; } = null!;

    public string ShiftId { get; set; } = null!;

    public string Rtype { get; set; } = null!;

    public int? SeqNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
