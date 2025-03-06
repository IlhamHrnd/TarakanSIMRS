using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MedicalDischargeSummaryBodyDiagram
{
    public string RegistrationNo { get; set; }

    public string BodyId { get; set; }

    public byte[] BodyImage { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string Notes { get; set; }
}
