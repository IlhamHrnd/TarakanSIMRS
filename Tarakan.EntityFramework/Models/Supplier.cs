using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Supplier
{
    public string SupplierId { get; set; } = null!;

    public string SupplierName { get; set; } = null!;

    public string? ShortName { get; set; }

    public string SrsupplierType { get; set; } = null!;

    public string ContractNumber { get; set; } = null!;

    public DateTime? ContractStart { get; set; }

    public DateTime? ContractEnd { get; set; }

    public string ContractSummary { get; set; } = null!;

    public string ContactPerson { get; set; } = null!;

    public bool IsPkp { get; set; }

    public string? TaxRegistrationNo { get; set; }

    public decimal? TermOfPayment { get; set; }

    public byte LeadTime { get; set; }

    public decimal CreditLimit { get; set; }

    public bool IsActive { get; set; }

    public string StreetName { get; set; } = null!;

    public string? District { get; set; }

    public string City { get; set; } = null!;

    public string County { get; set; } = null!;

    public string State { get; set; } = null!;

    public string? ZipCode { get; set; }

    public string PhoneNo { get; set; } = null!;

    public string FaxNo { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string MobilePhoneNo { get; set; } = null!;

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public int? ChartOfAccountIdAp { get; set; }

    public int? SubledgerIdAp { get; set; }

    public int? ChartOfAccountIdApinProcess { get; set; }

    public int? SubledgerIdApinProcess { get; set; }

    public decimal? TaxPercentage { get; set; }

    public int? ChartOfAccountIdAptemporary { get; set; }

    public int? SubledgerIdAptemporary { get; set; }

    public int? ChartOfAccountIdApcost { get; set; }

    public int? SubledgerIdApcost { get; set; }

    public string? PbflicenseNo { get; set; }

    public DateTime? PbflicenseValidDate { get; set; }

    public string? BankAccountNo { get; set; }

    public string? BankName { get; set; }

    public int? ChartOfAccountIdPoreturn { get; set; }

    public int? SubledgerIdPoreturn { get; set; }

    public string? SrapAgingDateType { get; set; }

    public int? ChartOfAccountIdApnonMedic { get; set; }

    public int? SubledgerIdApnonMedic { get; set; }

    public int? ChartOfAccountIdAptemporaryNonMedic { get; set; }

    public int? SubledgerIdAptemporaryNonMedic { get; set; }

    public int? ChartOfAccountIdPoreturnNonMedic { get; set; }

    public int? SubledgerIdPoreturnNonMedic { get; set; }

    public string? Branch { get; set; }

    public int? ChartOfAccountIdGrantReceive { get; set; }

    public int? SubledgerIdGrantReceive { get; set; }

    public int? ChartOfAccountIdGrantReceiveNmed { get; set; }

    public int? SubledgerIdGrantReceiveNmed { get; set; }

    public virtual ICollection<SupplierContract> SupplierContracts { get; set; } = new List<SupplierContract>();

    public virtual ICollection<SupplierFabric> SupplierFabrics { get; set; } = new List<SupplierFabric>();
}
