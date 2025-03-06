using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationPto
{
    public string RegistrationNo { get; set; }

    public int PtoNo { get; set; }

    public DateTime? PtoDateTime { get; set; }

    public string PtoS { get; set; }

    public string PtoO { get; set; }

    public string PtoA { get; set; }

    public string PtoP { get; set; }

    public bool? IsDeleted { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string ServiceUnitId { get; set; }

    public string RoomId { get; set; }

    public string BedId { get; set; }
}
