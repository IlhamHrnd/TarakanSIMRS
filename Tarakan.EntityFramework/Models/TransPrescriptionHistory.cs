using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPrescriptionHistory
{
    public string RecalculationProcessNo { get; set; }

    public string PrescriptionNo { get; set; }

    public DateTime PrescriptionDate { get; set; }

    public string RegistrationNo { get; set; }

    public string ServiceUnitId { get; set; }

    public string ClassId { get; set; }

    public string ParamedicId { get; set; }

    public bool IsApproval { get; set; }

    public bool IsVoid { get; set; }

    public string Note { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool IsPrescriptionReturn { get; set; }

    public string ReferenceNo { get; set; }

    public bool IsFromSoap { get; set; }

    public bool IsBillProceed { get; set; }

    public bool IsUnitDosePrescription { get; set; }

    public bool IsCito { get; set; }

    public bool IsClosed { get; set; }

    public DateTime? ApprovalDateTime { get; set; }

    public DateTime? DeliverDateTime { get; set; }
}
