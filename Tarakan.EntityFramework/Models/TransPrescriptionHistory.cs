using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPrescriptionHistory
{
    public string RecalculationProcessNo { get; set; } = null!;

    public string PrescriptionNo { get; set; } = null!;

    public DateTime PrescriptionDate { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string ServiceUnitId { get; set; } = null!;

    public string ClassId { get; set; } = null!;

    public string ParamedicId { get; set; } = null!;

    public bool IsApproval { get; set; }

    public bool IsVoid { get; set; }

    public string? Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public bool IsPrescriptionReturn { get; set; }

    public string ReferenceNo { get; set; } = null!;

    public bool IsFromSoap { get; set; }

    public bool IsBillProceed { get; set; }

    public bool IsUnitDosePrescription { get; set; }

    public bool IsCito { get; set; }

    public bool IsClosed { get; set; }

    public DateTime? ApprovalDateTime { get; set; }

    public DateTime? DeliverDateTime { get; set; }
}
