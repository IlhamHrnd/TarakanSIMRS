using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RevenueByCashBasis
{
    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string UserId { get; set; }

    public string PaymentNo { get; set; }

    public string PaymentReferenceNo { get; set; }

    public string RegistrationNo { get; set; }

    public string SrregistrationType { get; set; }

    public string PatientId { get; set; }

    public string ServiceUnitId { get; set; }

    public string ClassId { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string TransactionNo { get; set; }

    public string SequenceNo { get; set; }

    public string TariffComponentName { get; set; }

    public string ItemName { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Price { get; set; }

    public decimal? Discount { get; set; }

    public decimal? PatientAmount { get; set; }

    public decimal? GuarantorAmount { get; set; }

    public decimal? DiscountPatientAmount { get; set; }

    public decimal? DiscountGuarantorAmount { get; set; }

    public decimal? TotalIncome { get; set; }

    public string ParamedicName { get; set; }

    public string TxType { get; set; }
}
