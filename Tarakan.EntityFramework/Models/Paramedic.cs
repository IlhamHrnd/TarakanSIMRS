using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Paramedic
{
    public string ParamedicId { get; set; } = null!;

    public string ParamedicName { get; set; } = null!;

    public string ParamedicInitial { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public string SrparamedicType { get; set; } = null!;

    public string SrparamedicStatus { get; set; } = null!;

    public string Srreligion { get; set; } = null!;

    public string Srnationality { get; set; } = null!;

    public string Srspecialty { get; set; } = null!;

    public string StreetName { get; set; } = null!;

    public string District { get; set; } = null!;

    public string City { get; set; } = null!;

    public string County { get; set; } = null!;

    public string State { get; set; } = null!;

    public string? ZipCode { get; set; }

    public string PhoneNo { get; set; } = null!;

    public string FaxNo { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string MobilePhoneNo { get; set; } = null!;

    public string LicenseNo { get; set; } = null!;

    public string TaxRegistrationNo { get; set; } = null!;

    public bool IsPkp { get; set; }

    public bool IsAvailable { get; set; }

    public DateTime? NotAvailableUntil { get; set; }

    public bool IsAnesthetist { get; set; }

    public bool IsAudiologist { get; set; }

    public bool IsActive { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public DateTime? LicensePeriodeStart { get; set; }

    public DateTime? LicensePeriodeEnd { get; set; }

    public bool? IsParamedicFeeUsePercentage { get; set; }

    public decimal? ParamedicFeeAmount { get; set; }

    public string? Bank { get; set; }

    public string? BankAccount { get; set; }

    public decimal? ParamedicFeeAmountReferral { get; set; }

    public bool? IsUsingQue { get; set; }

    public string? SrparamedicRl1 { get; set; }

    public bool? IsDeductionFeeUsePercentage { get; set; }

    public decimal? DeductionFeeAmount { get; set; }

    public decimal? DeductionFeeAmountReferral { get; set; }

    public int? ChartOfAccountIdApparamedicFee { get; set; }

    public int? SubledgerIdApparamedicFee { get; set; }

    public bool? ParamedicFee { get; set; }

    public bool? IsPrintInSlip { get; set; }

    public string? Bank2 { get; set; }

    public string? BankAccount2 { get; set; }

    public byte[]? Foto { get; set; }

    public decimal? GuaranteeFee { get; set; }

    public int? CoorporateGradeId { get; set; }

    public decimal? CoorporateGradeValue { get; set; }

    public string? BankAccountName { get; set; }

    public string? BankAccountName2 { get; set; }

    public string? Ktp { get; set; }

    public string? Ssn { get; set; }

    public virtual ICollection<ParamedicSchedule> ParamedicSchedules { get; set; } = new List<ParamedicSchedule>();

    public virtual ICollection<ServiceUnitBooking> ServiceUnitBookings { get; set; } = new List<ServiceUnitBooking>();
}
