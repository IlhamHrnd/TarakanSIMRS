using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpSupplier
{
    public string SupplierId { get; set; }

    public string SupplierName { get; set; }

    public string ShortName { get; set; }

    public string SrsupplierType { get; set; }

    public string ContractNumber { get; set; }

    public DateTime? ContractStart { get; set; }

    public DateTime? ContractEnd { get; set; }

    public string ContractSummary { get; set; }

    public string ContactPerson { get; set; }

    public double? IsPkp { get; set; }

    public string TaxRegistrationNo { get; set; }

    public double? TermOfPayment { get; set; }

    public double? LeadTime { get; set; }

    public double? CreditLimit { get; set; }

    public double? IsActive { get; set; }

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

    public string F26 { get; set; }

    public string F27 { get; set; }

    public double? ChartOfAccountIdAp { get; set; }

    public double? SubledgerIdAp { get; set; }

    public double? ChartOfAccountIdApinProcess { get; set; }

    public double? SubledgerIdApinProcess { get; set; }

    public double? TaxPercentage { get; set; }

    public double? ChartOfAccountIdAptemporary { get; set; }

    public double? SubledgerIdAptemporary { get; set; }

    public double? ChartOfAccountIdApcost { get; set; }

    public double? SubledgerIdApcost { get; set; }

    public string PbflicenseNo { get; set; }

    public string PbflicenseValidDate { get; set; }

    public string BankAccountNo { get; set; }

    public string BankName { get; set; }

    public double? ChartOfAccountIdPoreturn { get; set; }

    public double? SubledgerIdPoreturn { get; set; }

    public double? SrapAgingDateType { get; set; }

    public double? ChartOfAccountIdApnonMedic { get; set; }

    public double? SubledgerIdApnonMedic { get; set; }

    public double? ChartOfAccountIdAptemporaryNonMedic { get; set; }

    public double? SubledgerIdAptemporaryNonMedic { get; set; }

    public double? ChartOfAccountIdPoreturnNonMedic { get; set; }

    public double? SubledgerIdPoreturnNonMedic { get; set; }

    public double? Branch { get; set; }

    public string ChartOfAccountIdGrantReceive { get; set; }

    public string SubledgerIdGrantReceive { get; set; }

    public string ChartOfAccountIdGrantReceiveNmed { get; set; }

    public double? SubledgerIdGrantReceiveNmed { get; set; }
}
