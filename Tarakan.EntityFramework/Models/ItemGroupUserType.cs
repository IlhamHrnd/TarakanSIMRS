using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ItemGroupUserType
{
    public string ItemGroupId { get; set; }

    public string SruserType { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
