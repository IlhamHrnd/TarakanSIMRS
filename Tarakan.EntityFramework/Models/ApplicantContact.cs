using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ApplicantContact
{
    public int ApplicantContactId { get; set; }

    public int ApplicantId { get; set; }

    public string SrcontactType { get; set; }

    public string ContactValue { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
