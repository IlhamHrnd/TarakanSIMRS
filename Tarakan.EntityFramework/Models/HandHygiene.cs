using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class HandHygiene
{
    public string TransactionNo { get; set; }

    public DateTime TransactionDate { get; set; }

    public string StartTime { get; set; }

    public string EndTime { get; set; }

    public short SessionLength { get; set; }

    public int ObserverId { get; set; }

    public int EmployeeId { get; set; }

    public int? DepartmentId { get; set; }

    public int? DivisionId { get; set; }

    public int? SubDivisionId { get; set; }

    public string ServiceUnitId { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string VoidByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
