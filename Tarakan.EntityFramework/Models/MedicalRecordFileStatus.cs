using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MedicalRecordFileStatus
{
    public string RegistrationNo { get; set; }

    public DateTime? FileOutDate { get; set; }

    public DateTime? FileInDate { get; set; }

    public string SrmedicalFileCategory { get; set; }

    public string SrmedicalFileStatus { get; set; }

    public string Notes { get; set; }

    public string RequestByUserId { get; set; }

    public string ReceiptByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? FileOutDateConfirmed { get; set; }

    public string FileOutUserIdcomfirmed { get; set; }
}
