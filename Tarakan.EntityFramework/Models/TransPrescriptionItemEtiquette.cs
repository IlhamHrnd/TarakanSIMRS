using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPrescriptionItemEtiquette
{
    public string PrescriptionNo { get; set; }

    public string SequenceNo { get; set; }

    public string ItemName { get; set; }

    public string ConsumeMethod { get; set; }

    public string Keeping { get; set; }

    public string SpecificInfo { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public bool IsDrugOutside { get; set; }

    public string CreateUserId { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string LastUpdateUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public int? NumberOfCopies { get; set; }

    public string BatchNumber { get; set; }
}
