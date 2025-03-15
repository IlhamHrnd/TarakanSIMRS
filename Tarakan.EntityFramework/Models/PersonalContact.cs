using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PersonalContact
{
    public int PersonalContactId { get; set; }

    public int PersonId { get; set; }

    public string SrcontactType { get; set; } = null!;

    public string ContactValue { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
