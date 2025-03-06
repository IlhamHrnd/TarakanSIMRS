using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppUserUserGroup
{
    public string UserId { get; set; }

    public string UserGroupId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
