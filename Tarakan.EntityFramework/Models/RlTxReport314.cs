using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RlTxReport314
{
    public string RlTxReportNo { get; set; }

    public int RlMasterReportItemId { get; set; }

    public int? RujukanPuskesmas { get; set; }

    public int? RujukanFasKesLain { get; set; }

    public int? RujukanRsLain { get; set; }

    public int? DirujukKePuskesmasAsal { get; set; }

    public int? DirujukKeFasKesAsal { get; set; }

    public int? DirujukKeRsAsal { get; set; }

    public int? DirujukPasienRujukan { get; set; }

    public int? DirujukPasienDtgSendiri { get; set; }

    public int? DirujukDiterimaKembali { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
