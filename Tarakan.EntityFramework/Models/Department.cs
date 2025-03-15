using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Department
{
    public string DepartmentId { get; set; } = null!;

    public string DepartmentName { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public string Initial { get; set; } = null!;

    public string DepartmentManager { get; set; } = null!;

    public bool IsHasRegistration { get; set; }

    public bool IsAllowBackDateRegistration { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public virtual ICollection<ServiceUnit> ServiceUnits { get; set; } = new List<ServiceUnit>();
}
