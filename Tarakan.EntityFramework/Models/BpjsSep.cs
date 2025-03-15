using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BpjsSep
{
    public long SepId { get; set; }

    public string? NoSep { get; set; }

    public string? NomorKartu { get; set; }

    public DateTime? TanggalSep { get; set; }

    public DateTime? TanggalRujukan { get; set; }

    public string? NoRujukan { get; set; }

    public string? Ppkrujukan { get; set; }

    public string? NamaPpkrujukan { get; set; }

    public string? Ppkpelayanan { get; set; }

    public string? JenisPelayanan { get; set; }

    public string? Catatan { get; set; }

    public string? DiagnosaAwal { get; set; }

    public string? PoliTujuan { get; set; }

    public string? KelasRawat { get; set; }

    public string? LakaLantas { get; set; }

    public string? User { get; set; }

    public string? NoMr { get; set; }

    public DateTime? TanggalPulang { get; set; }

    public string? NoTransaksi { get; set; }

    public string? NamaPasien { get; set; }

    public string? Nik { get; set; }

    public string? JenisKelamin { get; set; }

    public DateTime? TanggalLahir { get; set; }

    public string? JenisPeserta { get; set; }

    public string? DetailKeanggotaan { get; set; }

    public string? PatientId { get; set; }

    public string? KodeCbg { get; set; }

    public decimal? TariffCbg { get; set; }

    public string? DeskripsiCbg { get; set; }

    public string? LokasiLaka { get; set; }

    public string? NamaKelasRawat { get; set; }

    public bool? IsEksekutif { get; set; }

    public bool? IsCob { get; set; }

    public string? PenjaminLaka { get; set; }

    public string? NamaCob { get; set; }

    public string? StatusPeserta { get; set; }

    public string? Umur { get; set; }

    public string? JenisRujukan { get; set; }

    public bool? IsKatarak { get; set; }

    public DateTime? TglKejadian { get; set; }

    public bool? IsSuplesi { get; set; }

    public string? NoSepSuplesi { get; set; }

    public string? KodePropinsi { get; set; }

    public string? KodeKabupaten { get; set; }

    public string? KodeKecamatan { get; set; }

    public string? NoSkdp { get; set; }

    public string? KodeDpjp { get; set; }

    public string? FromRegistrationNo { get; set; }

    public string? ProlanisPrb { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? KodeDpjpPelayanan { get; set; }

    public string? KlsRawatNaik { get; set; }

    public string? Pembiayaan { get; set; }

    public string? PenanggungJawab { get; set; }

    public string? TujuanKunj { get; set; }

    public string? FlagProcedure { get; set; }

    public string? KdPenunjang { get; set; }

    public string? AssesmentPel { get; set; }

    public string? KodeDpjpKontrol { get; set; }

    public string? NoLp { get; set; }

    public string? KlsHak { get; set; }
}
