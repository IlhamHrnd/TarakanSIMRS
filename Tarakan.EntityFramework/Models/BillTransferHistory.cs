using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BillTransferHistory
{
    public string RegistrationNo { get; set; }

    public DateTime ProcessDateTime { get; set; }

    public string ProcessByUserId { get; set; }

    public bool IsPatientToGuarantor { get; set; }
}
