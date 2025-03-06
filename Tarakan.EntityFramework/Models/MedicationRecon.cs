using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MedicationRecon
{
    public string RegistrationNo { get; set; }

    public int ReconSeqNo { get; set; }

    public string ReconType { get; set; }

    public decimal? BodyWeight { get; set; }

    public string TransferNo { get; set; }

    public bool? IsFinish { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public byte[] SignImg { get; set; }

    public byte[] ParamedicSignImg { get; set; }

    public byte[] PatientSignImg { get; set; }

    public string ParamedicId { get; set; }
}
