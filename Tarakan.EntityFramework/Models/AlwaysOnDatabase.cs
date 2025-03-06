using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AlwaysOnDatabase
{
    public long AlwaysOnDatabasesId { get; set; }

    public Guid ReplicaId { get; set; }

    public Guid GroupId { get; set; }

    public Guid GroupDatabaseId { get; set; }

    public string ServerSourceName { get; set; }

    public int? DatabaseId { get; set; }

    public string DatabaseName { get; set; }

    public bool Delete { get; set; }
}
