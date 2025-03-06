using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SpectaclePrescription
{
    public string PrescriptionNo { get; set; }

    public DateTime PrescriptionDate { get; set; }

    public string RegistrationNo { get; set; }

    public string SrprescriptionType { get; set; }

    public string SrspectacleType { get; set; }

    public string SrlensType { get; set; }

    public string ServiceUnitId { get; set; }

    public string ClassId { get; set; }

    public string ParamedicId { get; set; }

    public DateTime DueDate { get; set; }

    public bool IsApproval { get; set; }

    public bool IsVoid { get; set; }

    public string Notes { get; set; }

    public bool IsPrescriptionReturn { get; set; }

    public string ReferenceNo { get; set; }

    public bool IsBillProceed { get; set; }

    public bool IsClosed { get; set; }

    public DateTime? ApprovalDateTime { get; set; }

    public DateTime? DeliverDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }
}
