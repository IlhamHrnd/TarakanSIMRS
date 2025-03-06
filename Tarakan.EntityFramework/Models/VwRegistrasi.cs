using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwRegistrasi
{
    public string RegistrationNo { get; set; }

    public string MedicalNo { get; set; }

    public DateTime RegistrationDate { get; set; }

    public DateTime? DischargeDate { get; set; }

    public string DiagAwal { get; set; }

    public string Identitas { get; set; }

    public string NoIdentitas { get; set; }

    public string KlasifikasiPasien { get; set; }

    public string NmKelPasien { get; set; }

    public string CaraMasuk { get; set; }

    public string PerujukDari { get; set; }

    public string KetPerujuk { get; set; }

    public string CaraKeluar { get; set; }

    public string DirujukKe { get; set; }

    public string KetDirujuk { get; set; }

    public string UserId { get; set; }

    public string LastCreateUserId { get; set; }

    public string NmPj { get; set; }

    public string AlamatPj { get; set; }

    public string KdKecamatanPj { get; set; }

    public string NoTelpPj { get; set; }

    public string IdentitasPj { get; set; }

    public string NoIdentitasPj { get; set; }

    public string HubPj { get; set; }

    public string KdLayanan { get; set; }

    public string KdDokter { get; set; }

    public string Tpp { get; set; }

    public string BadanUsaha { get; set; }

    public string HubKlasifikasi { get; set; }

    public string KelasTanggungan { get; set; }

    public string KdKelasReg { get; set; }

    public string Penanggung { get; set; }

    public string HubPenanggung { get; set; }

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
