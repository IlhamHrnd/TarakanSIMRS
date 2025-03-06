using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssessmentTypeBodyDiagram
{
    public string SrassessmentType { get; set; }

    public string BodyId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
