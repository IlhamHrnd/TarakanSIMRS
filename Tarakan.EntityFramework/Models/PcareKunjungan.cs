using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PcareKunjungan
{
    public string RegistrationNo { get; set; }

    public string NoKartu { get; set; }

    public string NoUrutPendaftaran { get; set; }

    public string NoKunjungan { get; set; }

    public string PendaftaranPostData { get; set; }

    public string KunjunganPostData { get; set; }

    public string ErrorResponse { get; set; }

    public bool? IsAllTindakanPosted { get; set; }

    public bool? IsAllObatPosted { get; set; }

    public bool? IsClosed { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string KdPoli { get; set; }
}
