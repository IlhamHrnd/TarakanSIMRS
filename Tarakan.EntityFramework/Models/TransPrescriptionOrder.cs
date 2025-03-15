using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TransPrescriptionOrder
{
    public string OrderNo { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string? Notes { get; set; }

    public bool IsApproval { get; set; }

    public bool IsVoid { get; set; }

    public DateTime? ApprovalDate { get; set; }

    public string? ApprovalBy { get; set; }

    public DateTime? VoidDate { get; set; }

    public string? VoidBy { get; set; }

    public bool IsClosed { get; set; }

    public DateTime CreateDateTime { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateBy { get; set; }
}
