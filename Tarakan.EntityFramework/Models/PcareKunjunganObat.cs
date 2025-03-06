using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PcareKunjunganObat
{
    public string PrescriptionNo { get; set; }

    public string SequenceNo { get; set; }

    public string RegistrationNo { get; set; }

    public string NoKunjungan { get; set; }

    public int? KdObatSk { get; set; }

    public string KdRacikan { get; set; }

    public string ErrorResponse { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
