using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppUserGroup
{
    public string UserGroupId { get; set; }

    public string UserGroupName { get; set; }

    public bool IsEditAble { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
