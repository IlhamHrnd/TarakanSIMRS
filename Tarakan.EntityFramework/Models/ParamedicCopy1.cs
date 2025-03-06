using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicCopy1
{
    public string ParamedicId { get; set; }

    public string ParamedicName { get; set; }

    public string ParamedicInitial { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string SrparamedicType { get; set; }

    public string SrparamedicStatus { get; set; }

    public string Srreligion { get; set; }

    public string Srnationality { get; set; }

    public string Srspecialty { get; set; }

    public string StreetName { get; set; }

    public string District { get; set; }

    public string City { get; set; }

    public string County { get; set; }

    public string State { get; set; }

    public string ZipCode { get; set; }

    public string PhoneNo { get; set; }

    public string FaxNo { get; set; }

    public string Email { get; set; }

    public string MobilePhoneNo { get; set; }

    public string LicenseNo { get; set; }

    public string TaxRegistrationNo { get; set; }

    public bool IsPkp { get; set; }

    public bool IsAvailable { get; set; }

    public DateTime? NotAvailableUntil { get; set; }

    public bool IsAnesthetist { get; set; }

    public bool IsAudiologist { get; set; }

    public bool IsActive { get; set; }

    public string Notes { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string RegistrationNo { get; set; }

    public DateTime? LicensePeriodeStart { get; set; }

    public DateTime? LicensePeriodeEnd { get; set; }

    public bool? IsParamedicFeeUsePercentage { get; set; }

    public decimal? ParamedicFeeAmount { get; set; }

    public string Bank { get; set; }

    public string BankAccount { get; set; }

    public decimal? ParamedicFeeAmountReferral { get; set; }

    public bool? IsUsingQue { get; set; }

    public string SrparamedicRl1 { get; set; }

    public bool? IsDeductionFeeUsePercentage { get; set; }

    public decimal? DeductionFeeAmount { get; set; }

    public decimal? DeductionFeeAmountReferral { get; set; }

    public int? ChartOfAccountIdApparamedicFee { get; set; }

    public int? SubledgerIdApparamedicFee { get; set; }

    public bool? ParamedicFee { get; set; }

    public bool? IsPrintInSlip { get; set; }

    public string Bank2 { get; set; }

    public string BankAccount2 { get; set; }

    public byte[] Foto { get; set; }

    public decimal? GuaranteeFee { get; set; }

    public int? CoorporateGradeId { get; set; }

    public decimal? CoorporateGradeValue { get; set; }
}
