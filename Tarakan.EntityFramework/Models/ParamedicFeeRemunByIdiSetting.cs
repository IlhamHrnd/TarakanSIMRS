using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicFeeRemunByIdiSetting
{
    public int SettingId { get; set; }

    public string SmfId { get; set; }

    public string ParamedicId { get; set; }

    public string ItemGroupId { get; set; }

    public string ItemId { get; set; }

    public decimal MultiplierValue { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
