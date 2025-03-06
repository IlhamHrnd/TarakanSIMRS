using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PathologyAnatomyImage
{
    public string ResultNo { get; set; }

    public int ImageNo { get; set; }

    public string DocumentName { get; set; }

    public byte[] DocumentImage { get; set; }

    public string DocumentNotes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string CreatedByUserId { get; set; }
}
