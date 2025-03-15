using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BillTransferHistory
{
    public string RegistrationNo { get; set; } = null!;

    public DateTime ProcessDateTime { get; set; }

    public string ProcessByUserId { get; set; } = null!;

    public bool IsPatientToGuarantor { get; set; }
}
