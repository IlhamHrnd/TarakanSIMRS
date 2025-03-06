using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicConsultForm
{
    public string ConsultReferNo { get; set; }

    public string TransactionNo { get; set; }

    public string RegistrationNo { get; set; }

    public string QuestionFormId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
