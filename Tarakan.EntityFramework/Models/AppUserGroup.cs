using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppUserGroup
{
    public string UserGroupId { get; set; } = null!;

    public string UserGroupName { get; set; } = null!;

    public bool IsEditAble { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
