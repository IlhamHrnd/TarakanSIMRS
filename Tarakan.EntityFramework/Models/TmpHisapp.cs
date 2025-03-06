using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpHisapp
{
    public int LogId { get; set; }

    public string ModuleApp { get; set; }

    public string RegistrationNo { get; set; }

    public string TransferNo { get; set; }

    public string BedId { get; set; }

    public string PatientId { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public Guid? CheckinConfirmId { get; set; }

    public DateTime? DischargeDate { get; set; }
}
