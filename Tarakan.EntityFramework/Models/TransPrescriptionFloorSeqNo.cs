using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPrescriptionFloorSeqNo
{
    public DateTime PrescriptionDate { get; set; }

    public string Srfloor { get; set; }

    public string ServiceUnitId { get; set; }

    public string ShiftId { get; set; }

    public string Rtype { get; set; }

    public int? SeqNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
