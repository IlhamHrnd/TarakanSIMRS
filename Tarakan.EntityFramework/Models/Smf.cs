using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Smf
{
    public string SmfId { get; set; }

    public string SmfName { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string SrparamedicFeeCaseType { get; set; }

    public string SrassessmentType { get; set; }

    public string SmfBackcolor { get; set; }
}
