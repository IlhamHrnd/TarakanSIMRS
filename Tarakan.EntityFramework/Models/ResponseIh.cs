using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ResponseIh
{
    public long IdResponseencounter { get; set; }

    public string Location { get; set; }

    public string Status { get; set; }

    public string Resourcetype { get; set; }

    public string Resourceid { get; set; }

    public string RegistrationNo { get; set; }

    public string MedicalNo { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
