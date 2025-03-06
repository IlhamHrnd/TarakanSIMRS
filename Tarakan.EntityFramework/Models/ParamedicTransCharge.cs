using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicTransCharge
{
    public string RegistrationNo { get; set; }

    public string ParamedicId { get; set; }

    public string TransactionNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
