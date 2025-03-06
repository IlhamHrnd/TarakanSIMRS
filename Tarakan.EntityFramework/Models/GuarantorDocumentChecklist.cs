using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class GuarantorDocumentChecklist
{
    public string GuarantorId { get; set; }

    public string SrregistrationType { get; set; }

    public string SrdocumentChecklist { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
