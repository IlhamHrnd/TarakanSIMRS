using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class EsignLogHist
{
    public long LogId { get; set; }

    public string ApiUrl { get; set; } = null!;

    public string? Nik { get; set; }

    public string? ProgramId { get; set; }

    public string? RegistrationNo { get; set; }

    public string? TransactionNo { get; set; }

    public string? SignedFilePath { get; set; }

    public string? ErrorMessage { get; set; }

    public int? StatusCode { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? CreatedByUserId { get; set; }
}
