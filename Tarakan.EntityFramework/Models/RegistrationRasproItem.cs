using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationRasproItem
{
    public string RegistrationNo { get; set; }

    public int RasproSeqNo { get; set; }

    public string ItemId { get; set; }

    public string ZatActiveId { get; set; }

    public string SritemUnit { get; set; }

    public string SrdosageUnit { get; set; }

    public string AcPcDc { get; set; }

    public string SrmedicationRoute { get; set; }

    public string SrconsumeMethod { get; set; }

    public string DosageQty { get; set; }

    public string EmbalaceQty { get; set; }

    public string ConsumeQty { get; set; }

    public string SrconsumeUnit { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? StartDateTime { get; set; }

    public DateTime? StopDateTime { get; set; }

    public int? PrevRasproSeqNo { get; set; }

    public string PrevRasproItemId { get; set; }
}
