using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpObat
{
    public double? No { get; set; }

    public string Id { get; set; }

    public string NamaMaterial { get; set; }

    public string BentukDosisDosageForm { get; set; }

    public string SatuanJual { get; set; }

    public string NamaDagang { get; set; }

    public double? UkuranKemasan { get; set; }

    public string SatuanKemasan { get; set; }

    public string DosageForm { get; set; }

    public string NamaGenerik { get; set; }

    public double? KekuatanObat { get; set; }

    public string SatuanKekuatan { get; set; }

    public string SatuanBesar { get; set; }

    public double? KonversiJualBeli { get; set; }

    public string Pabrik { get; set; }

    public string Group { get; set; }

    public double? Atc { get; set; }

    public string Ddd { get; set; }

    public double? HargaSatuan { get; set; }

    public string EkatalogNonEkatalog { get; set; }

    public string FornasNonFornas { get; set; }

    public string FormulariumNonFormularium { get; set; }

    public string KronisNonKronis { get; set; }

    public string RetriksiFornas { get; set; }

    public string RetriksiKronisBpjs { get; set; }

    public string KeteranganKhusus { get; set; }

    public string KelasTerapi { get; set; }

    public string GolonganObat { get; set; }

    public string LasaHighAlert { get; set; }

    public string ParetoAbc { get; set; }

    public string Ven { get; set; }

    public string CekExpired { get; set; }

    public string InventoryNonInventory { get; set; }

    public string Generic { get; set; }

    public string NonGeneric { get; set; }

    public string Precursor { get; set; }

    public string Narcotic { get; set; }

    public string Psychotropic { get; set; }

    public string Morphine { get; set; }

    public string Antibiotic { get; set; }

    public string F41 { get; set; }

    public string DosageForms { get; set; }

    public string UkuranKemasanDanSatuanKekuatan { get; set; }
}
