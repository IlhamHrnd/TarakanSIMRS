using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CssdSterileItemsUltrasoundItem
{
    public string TransactionNo { get; set; }

    public string TransactionSeqNo { get; set; }

    public string ReceivedNo { get; set; }

    public string ReceivedSeqNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
