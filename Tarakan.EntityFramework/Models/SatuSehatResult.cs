using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SatuSehatResult
{
    public Guid EncounterId { get; set; }

    public string ResourceType { get; set; }

    public int IndexNo { get; set; }

    public string Category { get; set; }

    public string Code { get; set; }

    public Guid? ResultId { get; set; }

    public string PostData { get; set; }

    public string ErrorResponse { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
