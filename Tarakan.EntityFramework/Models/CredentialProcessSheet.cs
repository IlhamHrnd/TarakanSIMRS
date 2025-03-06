using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class CredentialProcessSheet
{
    public string TransactionNo { get; set; }

    public int QuestionnaireItemId { get; set; }

    public string SrcurrentAbility { get; set; }

    public string Srreview { get; set; }

    public string Srrecomendation { get; set; }

    public bool? IsRequested { get; set; }

    public bool? IsReduced { get; set; }

    public string Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
