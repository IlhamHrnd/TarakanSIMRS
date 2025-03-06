using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwTransaction
{
    public string TransactionNo { get; set; }

    public DateTime TransactionDate { get; set; }

    public string RegistrationNo { get; set; }

    public string ServiceUnitId { get; set; }

    public string ReferenceNo { get; set; }

    public bool IsCorrection { get; set; }

    public DateTime FilterDate { get; set; }

    public string OrderTransNo { get; set; }

    public DateTime OrderDate { get; set; }

    public int? IsPackage { get; set; }

    public string PackageReferenceNo { get; set; }

    public bool? IsPrescription { get; set; }

    public string ClassId { get; set; }
}
