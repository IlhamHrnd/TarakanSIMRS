using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationInfoMedicBodyDiagram
{
    public string RegistrationInfoMedicId { get; set; }

    public string BodyId { get; set; }

    public string ServiceUnitId { get; set; }

    public string ParamedicId { get; set; }

    public byte[] BodyImage { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string Notes { get; set; }
}
