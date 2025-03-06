using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AnalysisConfigBlockedDatabase
{
    public int AnalysisConfigurationId { get; set; }

    public int DatabaseId { get; set; }

    public virtual AnalysisConfiguration AnalysisConfiguration { get; set; }

    public virtual SqlserverDatabaseName Database { get; set; }
}
