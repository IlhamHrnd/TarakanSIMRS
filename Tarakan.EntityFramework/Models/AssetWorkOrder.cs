using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AssetWorkOrder
{
    public string OrderNo { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public string FromServiceUnitId { get; set; } = null!;

    public string ToServiceUnitId { get; set; } = null!;

    public string AssetId { get; set; } = null!;

    public string? ItemId { get; set; }

    public decimal? Qty { get; set; }

    public string ProblemDescription { get; set; } = null!;

    public string SrworkStatus { get; set; } = null!;

    public string? SrworkType { get; set; }

    public string? SrworkPriority { get; set; }

    public string? SrworkTrade { get; set; }

    public DateTime? RequiredDate { get; set; }

    public string? RequestByUserId { get; set; }

    public DateTime? ReceivedDateTime { get; set; }

    public string? ReceivedByUserId { get; set; }

    public string? SrfailureCode { get; set; }

    public string? FailureCauseDescription { get; set; }

    public string? ActionTaken { get; set; }

    public string? PreventionTaken { get; set; }

    public decimal? CostEstimation { get; set; }

    public string? LastRealizationByUserId { get; set; }

    public DateTime? LastRealizationDateTime { get; set; }

    public string? AcceptedByUserId { get; set; }

    public DateTime? AcceptedDateTime { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsVoid { get; set; }

    public bool? IsProceed { get; set; }

    public bool? IsPreventiveMaintenance { get; set; }

    public string? Pmno { get; set; }

    public bool? IsGeneratePrDr { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string? ImplementedBy { get; set; }

    public string? AcceptedBy { get; set; }

    public string? SentToThirdPartiesByUserId { get; set; }

    public DateTime? SentToThirdPartiesDateTime { get; set; }

    public string? ReceivedFromThirdPartiesByUserId { get; set; }

    public DateTime? ReceivedFromThirdPartiesDateTime { get; set; }

    public string? ReceivedFromLogisticsByUserId { get; set; }

    public DateTime? ReceivedFromLogisticsDateTime { get; set; }

    public string? ReferenceNo { get; set; }

    public string? LetterNo { get; set; }

    public string? SupplierId { get; set; }

    public DateTime? FirstResponseDateTime { get; set; }

    public string? FirstResponseByUserId { get; set; }

    public string? SrworkTradeItem { get; set; }

    public bool? IsSanitation { get; set; }

    public string? SrworkOrderPoint { get; set; }

    public decimal? WorkOrderPoint { get; set; }
}
