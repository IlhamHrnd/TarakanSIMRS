using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpTx
{
    public string? UserId { get; set; }

    public string? RegistrationNo { get; set; }

    public string? ItemGroupName { get; set; }

    public string? ItemIddetail { get; set; }

    public string? ItemDr { get; set; }

    public string? ItemName { get; set; }

    public string? Idgroup { get; set; }

    public string? NameBilling { get; set; }

    public string? ClassDt { get; set; }

    public string? ClassNameDt { get; set; }

    public string? Suname { get; set; }

    public string? Su { get; set; }

    public decimal? Price { get; set; }

    public decimal? ChargeQuantity { get; set; }

    public decimal? DiscountAmount { get; set; }

    public string? ParamedicCollectionName { get; set; }

    public decimal? TotalPa { get; set; }

    public decimal? TotalGa { get; set; }

    public decimal? Total { get; set; }

    public string? TransactionNo { get; set; }

    public string? SequenceNo { get; set; }

    public string? ReferenceNo { get; set; }

    public string? ReferenceSequenceNo { get; set; }

    public string? ItemGroupId { get; set; }

    public bool? IsPrintWithDoctorName { get; set; }
}
