using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EpisodeBodyDiagram
{
    public string RegistrationNo { get; set; }

    public int SequenceNo { get; set; }

    public string ServiceUnitId { get; set; }

    public string ParamedicId { get; set; }

    public byte[] BodyImage { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public virtual Registration RegistrationNoNavigation { get; set; }
}
