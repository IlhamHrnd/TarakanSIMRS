using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AdmDischargemon
{
    public string RegistrationNo { get; set; }

    public DateTime? PenrekdateLengkap { get; set; }

    public DateTime? PenrekdateTdklengkap { get; set; }

    public DateTime? MppdateResume { get; set; }

    public DateTime? MppdateStg { get; set; }

    public DateTime? CasemixdateAnalisis { get; set; }

    public DateTime? MbdateKlaim { get; set; }

    public float? Numcodgroup { get; set; }

    public string Diagnosa { get; set; }

    public DateTime? Mpptopenrek { get; set; }

    public DateTime? Penrektocasemix { get; set; }

    public DateTime? Codedangroup { get; set; }

    public DateTime? Vutmobda { get; set; }
}
