using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwHasilPasien
{
    public string OrderLabNo { get; set; }

    public string LabOrderCode { get; set; }

    public string LabOrderSummary { get; set; }

    public string Result { get; set; }

    public string StandarValue { get; set; }

    public DateTime? OrderLabTglOrder { get; set; }

    public string TestGroup { get; set; }

    public string OrderTestid { get; set; }

    public string DispSeq { get; set; }

    public string PatientId { get; set; }

    public string Unit { get; set; }

    public string TestComment { get; set; }

    public string Cmt { get; set; }

    public string RefRange { get; set; }

    public string Flag { get; set; }

    public string ValidateBy { get; set; }

    public string ValidateOn { get; set; }
}
