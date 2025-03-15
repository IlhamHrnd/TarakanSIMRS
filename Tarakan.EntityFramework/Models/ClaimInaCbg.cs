using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ClaimInaCbg
{
    public string SepNo { get; set; } = null!;

    public decimal TarifRs { get; set; }

    public decimal ProsedurBedah { get; set; }

    public decimal ProsedurNonBedah { get; set; }

    public decimal Konsultasi { get; set; }

    public decimal TenagaAhli { get; set; }

    public decimal Keperawatan { get; set; }

    public decimal Penunjang { get; set; }

    public decimal Radiologi { get; set; }

    public decimal Laboratorium { get; set; }

    public decimal PelayananDarah { get; set; }

    public decimal Rehabilitasi { get; set; }

    public decimal Kamar { get; set; }

    public decimal RawatIntensif { get; set; }

    public decimal Obat { get; set; }

    public decimal ObatKronis { get; set; }

    public decimal ObatKemoterapi { get; set; }

    public decimal Alkes { get; set; }

    public decimal Bmhp { get; set; }

    public decimal SewaAlat { get; set; }

    public string GrouperCbg { get; set; } = null!;

    public decimal GrouperTariff { get; set; }

    public decimal GrouperTariffLain { get; set; }

    public string KlaimStatusCd { get; set; } = null!;

    public string Diagnosa { get; set; } = null!;

    public string Procedure { get; set; } = null!;

    public string DiagnosaInaGrouper { get; set; } = null!;

    public string ProcedureInaGrouper { get; set; } = null!;

    public string NomorRm { get; set; } = null!;

    public DateTime CreatedDateTime { get; set; }

    public DateTime TanggalMasuk { get; set; }

    public DateTime TanggalKeluar { get; set; }
}
