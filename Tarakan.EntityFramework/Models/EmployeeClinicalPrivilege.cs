using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EmployeeClinicalPrivilege
{
    public int EmployeeClinicalPrivilegeId { get; set; }

    public int PersonId { get; set; }

    public string SrprofessionGroup { get; set; }

    public string SrclinicalWorkArea { get; set; }

    public string SrclinicalAuthorityLevel { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public string DecreeNo { get; set; }

    public string TransactionNo { get; set; }

    public string Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
