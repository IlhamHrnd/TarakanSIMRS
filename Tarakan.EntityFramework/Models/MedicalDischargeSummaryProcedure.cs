using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MedicalDischargeSummaryProcedure
{
    public string RegistrationNo { get; set; }

    public string SequenceNo { get; set; }

    public string ProcedureId { get; set; }

    public string ProcedureName { get; set; }

    public string ParamedicId { get; set; }

    public bool IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
