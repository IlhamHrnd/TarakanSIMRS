using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpKasirGdbaru
{
    public string UserId { get; set; }

    public string PaymentNo { get; set; }

    public string ServiceUnitId { get; set; }

    public string ServiceUnitName { get; set; }

    public string Pembayaran { get; set; }

    public string RegistrationNo { get; set; }

    public string PatientId { get; set; }

    public decimal? Sarana { get; set; }

    public decimal? Dokter { get; set; }

    public decimal? Kartu { get; set; }

    public decimal? BiayaReg { get; set; }

    public decimal? ByaAdmin { get; set; }

    public decimal? Tagihan { get; set; }

    public decimal? Pelunasan { get; set; }

    public decimal? Diskon { get; set; }

    public decimal? Piutang { get; set; }

    public decimal? Total { get; set; }

    public string Shift { get; set; }

    public string ShiftName { get; set; }

    public string SrregistrationType { get; set; }

    public decimal? Rounding { get; set; }

    public string CashierName { get; set; }

    public string NamaDokter { get; set; }

    public string Penjamin { get; set; }

    public DateTime? StampTime { get; set; }

    public decimal? Tindakan { get; set; }
}
