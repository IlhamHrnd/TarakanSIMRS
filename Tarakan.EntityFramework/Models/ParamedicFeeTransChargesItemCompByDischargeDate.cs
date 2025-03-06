using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicFeeTransChargesItemCompByDischargeDate
{
    public string TransactionNo { get; set; }

    public string SequenceNo { get; set; }

    public string TariffComponentId { get; set; }

    public DateTime? DischargeDate { get; set; }

    public bool IsOrderRealization { get; set; }

    public string ParamedicId { get; set; }

    public string ItemId { get; set; }

    public decimal Qty { get; set; }

    public decimal Price { get; set; }

    public decimal Discount { get; set; }

    public decimal? FeeAmount { get; set; }

    public bool? IsRefferal { get; set; }

    public bool? IsCalculatedInPercent { get; set; }

    public decimal? CalculatedAmount { get; set; }

    public bool? IsFree { get; set; }

    public DateTime? LastCalculatedDateTime { get; set; }

    public string LastCalculatedByUserId { get; set; }

    public string VerificationNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsCalcDeductionInPercent { get; set; }

    public decimal? CalcDeductionAmount { get; set; }

    public decimal? DeductionAmount { get; set; }

    public int? JournalId { get; set; }

    public string OldParamedicId { get; set; }

    public bool IsModified { get; set; }

    public decimal PriceItem { get; set; }

    public decimal DiscountItem { get; set; }

    public string TransactionNoRef { get; set; }

    public string RegistrationNo { get; set; }

    public string RegistrationNoMergeTo { get; set; }

    public DateTime? DischargeDateMergeTo { get; set; }

    public string Notes { get; set; }

    public string PaymentMethodName { get; set; }

    public string SrphysicianFeeCategory { get; set; }

    public string SrparamedicFeeCaseType { get; set; }

    public string SrparamedicFeeTeamStatus { get; set; }

    public string SrparamedicFeeIsTeam { get; set; }

    public decimal? SumDeductionAmount { get; set; }

    public int? ParamedicFeeByServiceSettingId { get; set; }

    public string SmfId { get; set; }

    public bool? IsGuarantorVerified { get; set; }

    public decimal? PerformanceGross { get; set; }

    public decimal? AdditionalSum { get; set; }

    public decimal? DeductionConvertion { get; set; }

    public decimal? DeductionAnesthetic { get; set; }

    public decimal? DeductionResult { get; set; }

    public decimal? Performance { get; set; }

    public decimal? DiscountExtra { get; set; }

    public string PaymentNoCash { get; set; }

    public string PaymentNoAr { get; set; }

    public string InvoicePaymentNo { get; set; }

    public bool? IsWriteOff { get; set; }

    public string InvoiceWriteOffNo { get; set; }

    public decimal? PercentagePayment { get; set; }

    public DateTime? LastPaymentDate { get; set; }

    public string PaymentNoGuarAr { get; set; }

    public string InvoicePaymentNoGuar { get; set; }

    public decimal? PercentagePaymentAr { get; set; }

    public decimal? PercentagePaymentGuarAr { get; set; }

    public string ChangeNote { get; set; }

    public decimal? SumDeductionAmountAfterTax { get; set; }

    public decimal? FeeAmountToBePaid { get; set; }

    public decimal? FeeAmountUpdateByUserId { get; set; }

    public DateTime? FeeAmountUpdateDateTime { get; set; }

    public string FeeAmountToBePaidChangeNote { get; set; }

    public string PaymentGroupNo { get; set; }

    public bool? IsCustom { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string CreateByUserId { get; set; }

    public string Srprocedure1 { get; set; }

    public string ExecutedFormula { get; set; }

    public string ExecutedMessage { get; set; }

    public bool? IsForTakeOneHighest { get; set; }

    public decimal? PctgPropCash { get; set; }

    public decimal? PctgPropAr { get; set; }

    public decimal? PctgPropArguar { get; set; }

    public decimal? TotalBill { get; set; }

    public int? RemunByIdiId { get; set; }

    public bool? IsBrutoFromFeeAmount { get; set; }

    public decimal? FeeAmountBruto { get; set; }
}
