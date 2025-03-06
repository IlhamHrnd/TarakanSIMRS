using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Guarantor
{
    public string GuarantorId { get; set; }

    public string GuarantorName { get; set; }

    public string ShortName { get; set; }

    public string SrguarantorType { get; set; }

    public string ContractNumber { get; set; }

    public DateTime? ContractStart { get; set; }

    public DateTime? ContractEnd { get; set; }

    public string ContractSummary { get; set; }

    public string ContactPerson { get; set; }

    public bool IsActive { get; set; }

    public string SrbusinessMethod { get; set; }

    public string SrtariffType { get; set; }

    public string SrguarantorRuleType { get; set; }

    public bool IsValueInPercent { get; set; }

    public decimal AmountValue { get; set; }

    public decimal AdminPercentage { get; set; }

    public decimal AdminAmountLimit { get; set; }

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

    public int? ChartOfAccountId { get; set; }

    public int? SubLedgerId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsIncludeItemMedical { get; set; }

    public bool? IsIncludeItemNonMedical { get; set; }

    public bool? IsIncludeItemOptic { get; set; }

    public bool? IsIncludeItemMedicalToGuarantor { get; set; }

    public bool? IsIncludeItemNonMedicalToGuarantor { get; set; }

    public bool? IsIncludeItemOpticToGuarantor { get; set; }

    public bool? IsCoverInpatient { get; set; }

    public bool? IsCoverOutpatient { get; set; }

    public decimal? ItemMedicMarginPercentage { get; set; }

    public string ItemMedicMarginId { get; set; }

    public decimal? ItemNonMedicMarginPercentage { get; set; }

    public string ItemNonMedicMarginId { get; set; }

    public string GuarantorHeaderId { get; set; }

    public bool? IsIncludeAdminValue { get; set; }

    public decimal? AdminValueMinimum { get; set; }

    public bool? IsGlobalPlafond { get; set; }

    public bool? IsAdminFromTotal { get; set; }

    public decimal? AdminPercentageOp { get; set; }

    public decimal? AdminAmountLimitOp { get; set; }

    public decimal? AdminValueMinimumOp { get; set; }

    public int? ChartOfAccountIdTemporary { get; set; }

    public int? SubledgerIdTemporary { get; set; }

    public bool? IsItemRuleUsingDefaultAmountValue { get; set; }

    public decimal? OutpatientAmountValue { get; set; }

    public decimal? EmergencyAmountValue { get; set; }

    public string SrpaymentType { get; set; }

    public string SrphysicianFeeType { get; set; }

    public int? ChartOfAccountIdDeposit { get; set; }

    public int? SubledgerIdDeposit { get; set; }

    public int? TermOfPayment { get; set; }

    public int? ChartOfAccountIdOverPayment { get; set; }

    public int? SubledgerIdOverPayment { get; set; }

    public string SrphysicianFeeCategory { get; set; }

    public int? ChartOfAccountIdCostParamedicFee { get; set; }

    public int? SubledgerIdCostParamedicFee { get; set; }

    public bool? IsExcessPlafonToDiscount { get; set; }

    public string VirtualAccountNo { get; set; }

    public string ReportRlid { get; set; }

    public int? RlMasterReportItemId { get; set; }

    public bool? IsCoverAllAdminCosts { get; set; }

    public string SrguarantorIncomeGroup { get; set; }

    public string PrescriptionServiceUnitIdIpr { get; set; }

    public string PrescriptionLocationIdIpr { get; set; }

    public string PrescriptionServiceUnitIdOpr { get; set; }

    public string PrescriptionLocationIdOpr { get; set; }

    public string PrescriptionServiceUnitIdEmr { get; set; }

    public string PrescriptionLocationIdEmr { get; set; }

    public bool? IsItemRestrictionsFornas { get; set; }

    public bool? IsProrateParamedicFee { get; set; }

    public byte? TariffCalculationMethod { get; set; }

    public string NoteCompanyList { get; set; }

    public bool? IsAdminCalcBeforeDiscount { get; set; }

    public bool? IsParamedicFeeRemun { get; set; }

    public decimal? RoundingTransaction { get; set; }

    public bool? IsUsingRoundingDown { get; set; }

    public decimal? CreditLimit { get; set; }

    public decimal? CreditAmount { get; set; }

    public string VirtualAccountBank { get; set; }

    public string VirtualAccountName { get; set; }

    public bool? IsFeeBrutoFromFeeAmount { get; set; }

    public int? ChartOfAccountIdIpr { get; set; }

    public int? SubLedgerIdIpr { get; set; }

    public int? ChartOfAccountIdTemporaryIpr { get; set; }

    public int? SubledgerIdTemporaryIpr { get; set; }

    public bool? IsItemRestrictionsFormularium { get; set; }

    public bool? IsItemRestrictionsGeneric { get; set; }

    public bool? IsItemRestrictionsNonGeneric { get; set; }

    public bool? IsItemRestrictionsNonGenericLimited { get; set; }

    public int? ChartOfAccountIdOverPaymentMin { get; set; }

    public int? SubledgerIdOverPaymentMin { get; set; }

    public bool? IsDiscountProrataToRevenue { get; set; }
}
