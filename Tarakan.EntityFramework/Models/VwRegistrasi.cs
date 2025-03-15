using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwRegistrasi
{
    public string RegistrationNo { get; set; } = null!;

    public string? MedicalNo { get; set; }

    public DateTime RegistrationDate { get; set; }

    public DateTime? DischargeDate { get; set; }

    public string DiagAwal { get; set; } = null!;

    public string Identitas { get; set; } = null!;

    public string NoIdentitas { get; set; } = null!;

    public string KlasifikasiPasien { get; set; } = null!;

    public string NmKelPasien { get; set; } = null!;

    public string CaraMasuk { get; set; } = null!;

    public string PerujukDari { get; set; } = null!;

    public string KetPerujuk { get; set; } = null!;

    public string CaraKeluar { get; set; } = null!;

    public string DirujukKe { get; set; } = null!;

    public string KetDirujuk { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string? LastCreateUserId { get; set; }

    public string NmPj { get; set; } = null!;

    public string AlamatPj { get; set; } = null!;

    public string KdKecamatanPj { get; set; } = null!;

    public string NoTelpPj { get; set; } = null!;

    public string IdentitasPj { get; set; } = null!;

    public string NoIdentitasPj { get; set; } = null!;

    public string HubPj { get; set; } = null!;

    public string KdLayanan { get; set; } = null!;

    public string KdDokter { get; set; } = null!;

    public string Tpp { get; set; } = null!;

    public string BadanUsaha { get; set; } = null!;

    public string HubKlasifikasi { get; set; } = null!;

    public string KelasTanggungan { get; set; } = null!;

    public string KdKelasReg { get; set; } = null!;

    public string Penanggung { get; set; } = null!;

    public string HubPenanggung { get; set; } = null!;

    public int? MatiUgd { get; set; }

    public int? MatiSebelumUgd { get; set; }

    public int? Lebih15Jam { get; set; }

    public int? StatusAntrian { get; set; }

    public int? KasusBaru { get; set; }

    public int? TekananDarah { get; set; }

    public int? Nadi { get; set; }

    public int? Suhu { get; set; }

    public int? BeratBadan { get; set; }

    public int? Gds { get; set; }

    public int? Ekg { get; set; }

    public int? Ekgmonitor { get; set; }

    public int? Kkpg { get; set; }

    public int? Pgd { get; set; }

    public int? Observasi { get; set; }

    public int? Keterangan { get; set; }

    public int? SebabKecelakaan { get; set; }
}
