using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientDocument
{
    public long PatientDocumentId { get; set; }

    public string PatientId { get; set; }

    public string RegistrationNo { get; set; }

    public string FileAttachName { get; set; }

    public string DocumentName { get; set; }

    public DateTime? DocumentDate { get; set; }

    public string Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public byte[] SmallImage { get; set; }

    public string OriFileName { get; set; }

    public string OriPath { get; set; }

    public bool? IsUpload { get; set; }

    public bool? IsDeleted { get; set; }

    public string ReferenceNo { get; set; }
}
