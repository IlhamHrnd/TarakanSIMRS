using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BpjsPesertum
{
    public string NoKartu { get; set; } = null!;

    public string Nama { get; set; } = null!;

    public string? HubunganKeluarga { get; set; }

    public string? Sex { get; set; }

    public DateOnly? TglLahir { get; set; }

    public DateOnly? TglMulaiAktif { get; set; }

    public DateOnly? TglAkhirBerlaku { get; set; }

    public string? KdProviderPstKdProvider { get; set; }

    public string? KdProviderPstNmProvider { get; set; }

    public string? KdProviderGigiKdProvider { get; set; }

    public string? KdProviderGigiNmProvider { get; set; }

    public string? JnsKelasKode { get; set; }

    public string? JnsKelasNama { get; set; }

    public string? JnsPesertaKode { get; set; }

    public string? JnsPesertaNama { get; set; }

    public string? GolDarah { get; set; }

    public string? NoHp { get; set; }

    public string? NoKtp { get; set; }

    public bool? Aktif { get; set; }

    public string? KetAktif { get; set; }

    public string? AsuransiKdAsuransi { get; set; }

    public string? AsuransiNmAsuransi { get; set; }

    public string? AsuransiNoAsuransi { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }
}
