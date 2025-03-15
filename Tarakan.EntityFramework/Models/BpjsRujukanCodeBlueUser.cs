using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BpjsRujukanCodeBlueUser
{
    public string Id { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime? CreatedDateTime { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public DateTime? LastLoggedInDateTime { get; set; }

    public string Email { get; set; } = null!;
}
