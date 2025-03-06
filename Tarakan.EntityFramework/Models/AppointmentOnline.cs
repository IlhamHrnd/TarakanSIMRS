using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppointmentOnline
{
    public string AppointmentNo { get; set; }

    public string QrCode { get; set; }

    public string ServiceUnitId { get; set; }

    public string ParamedicId { get; set; }

    public string PatientId { get; set; }

    public DateTime AppointmentDate { get; set; }

    public string GuarantorCardNo { get; set; }

    public string RujukanNo { get; set; }

    public string BpjsRujukanPoliCode { get; set; }

    public string BpjsRujukanPoliName { get; set; }

    public string RujukanJenisRanap { get; set; }

    public string RujukanKelasRawat { get; set; }

    public string RujukanAsalFaskes { get; set; }

    public string TujuanPoliCode { get; set; }

    public string TujuanPoliName { get; set; }

    public string BpjsDpjpKode { get; set; }

    public string BpjsDpjpName { get; set; }

    public string BpjsSepNo { get; set; }

    public string BpjsSepDiagnosa { get; set; }

    public bool? IsAfterInpatient { get; set; }

    public string GuarantorId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime? UpdateDateTime { get; set; }

    public string UpdateByUserId { get; set; }

    public string SrappoinmentType { get; set; }

    public bool? JenisRujukan { get; set; }

    public string RegistrationNo { get; set; }

    public string SuratKontrolNo { get; set; }

    public string SuratKontrolDpjpLayan { get; set; }

    public string BpjsTujuanPoliCode { get; set; }

    public string BpjsTujuanPoliName { get; set; }

    public string BpjsJenisPesertaKeterangan { get; set; }

    public string BpjsDiagnosaCode { get; set; }

    public string BpjsDiagnosaName { get; set; }

    public string Catatan { get; set; }

    public string BpjsJenisPesertaCode { get; set; }

    public string BpjsJenisPesertaName { get; set; }

    public string BpjsCob { get; set; }

    public string BpjsPenjamin { get; set; }

    public bool? IsRegistered { get; set; }
}
