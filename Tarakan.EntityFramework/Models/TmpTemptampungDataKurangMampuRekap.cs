using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpTemptampungDataKurangMampuRekap
{
    public string RegistrationNo { get; set; }

    public string PatientId { get; set; }

    public string ServiceUnitId { get; set; }

    public string RoomId { get; set; }

    public string GuarantorId { get; set; }

    public decimal? Kartu { get; set; }

    public decimal? DiskonKartu { get; set; }

    public decimal? Registrasi { get; set; }

    public decimal? DiskonRegistrasi { get; set; }

    public decimal? Poli { get; set; }

    public decimal? DiskonPoli { get; set; }

    public decimal? Obat { get; set; }

    public decimal? DiskonObat { get; set; }

    public decimal? Penunjang { get; set; }

    public decimal? DiskonPenunjang { get; set; }

    public decimal? Igd { get; set; }

    public decimal? DiskonIgd { get; set; }

    public decimal? Dokter { get; set; }

    public decimal? DiskonDokter { get; set; }

    public decimal? Adm { get; set; }

    public decimal? DiskonAdm { get; set; }

    public decimal? DiskonGlobal { get; set; }

    public decimal? JmlBayar { get; set; }

    public string UserId { get; set; }

    public DateTime? TimeStamp { get; set; }
}
