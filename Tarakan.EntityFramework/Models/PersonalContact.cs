using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PersonalContact
{
    public int PersonalContactId { get; set; }

    public int PersonId { get; set; }

    public string SrcontactType { get; set; }

    public string ContactValue { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
