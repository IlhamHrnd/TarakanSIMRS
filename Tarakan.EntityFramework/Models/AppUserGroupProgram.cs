using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppUserGroupProgram
{
    public string UserGroupId { get; set; }

    public string ProgramId { get; set; }

    public bool? IsUserGroupAddAble { get; set; }

    public bool? IsUserGroupEditAble { get; set; }

    public bool? IsUserGroupDeleteAble { get; set; }

    public bool? IsUserGroupApprovalAble { get; set; }

    public bool? IsUserGroupUnApprovalAble { get; set; }

    public bool? IsUserGroupVoidAble { get; set; }

    public bool? IsUserGroupUnVoidAble { get; set; }

    public bool? IsUserGroupExportAble { get; set; }

    public bool? IsUserGroupCrossUnitAble { get; set; }

    public bool? IsUserGroupPowerUserAble { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
