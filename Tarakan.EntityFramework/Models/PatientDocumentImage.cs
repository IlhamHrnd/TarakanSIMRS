using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientDocumentImage
{
    public string PatientId { get; set; }

    public int SequenceNo { get; set; }

    public string RegistrationNo { get; set; }

    public string SrimageTemplateType { get; set; }

    public string ImageTemplateId { get; set; }

    public string Name { get; set; }

    public string Notes { get; set; }

    public byte[] Image { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
