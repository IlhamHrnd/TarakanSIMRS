using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SqlserverTableName
{
    public int TableId { get; set; }

    public int DatabaseId { get; set; }

    public string TableName { get; set; }

    public string SchemaName { get; set; }

    public bool SystemTable { get; set; }

    public virtual SqlserverDatabaseName Database { get; set; }

    public virtual ICollection<TableGrowth> TableGrowths { get; set; } = new List<TableGrowth>();

    public virtual ICollection<TableReorganization> TableReorganizations { get; set; } = new List<TableReorganization>();
}
