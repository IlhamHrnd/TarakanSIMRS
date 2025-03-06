using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PrintJob
{
    public long PrintNo { get; set; }

    public DateTime PrintDateTime { get; set; }

    public string ProgramId { get; set; }

    public string PrinterId { get; set; }

    public string UserId { get; set; }

    public string ZplCommand { get; set; }

    public string ApplicationId { get; set; }

    public string UserHostName { get; set; }
}
