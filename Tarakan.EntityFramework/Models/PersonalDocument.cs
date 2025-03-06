using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PersonalDocument
{
    public long PersonalDocumentId { get; set; }

    public int PersonId { get; set; }

    public string FileAttachName { get; set; }

    public string DocumentName { get; set; }

    public DateTime? DocumentDate { get; set; }

    public string Notes { get; set; }

    public byte[] SmallImage { get; set; }

    public string OriFileName { get; set; }

    public string OriPath { get; set; }

    public bool? IsUpload { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string DocumentCode { get; set; }

    public int? RefferenceId { get; set; }
}
