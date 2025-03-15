using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VehicleTransaction
{
    public string TransactionNo { get; set; } = null!;

    public DateTime BookingDateTimeStart { get; set; }

    public DateTime BookingDateTimeEnd { get; set; }

    public string SrvehicleType { get; set; } = null!;

    public string Destination { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public string? ServiceUnitId { get; set; }

    public decimal DistanceInKm { get; set; }

    public int? VehicleId { get; set; }

    public int? DriverId { get; set; }

    public decimal? OdometerStart { get; set; }

    public decimal? OdometerEnd { get; set; }

    public DateTime? RealizationDateTimeStart { get; set; }

    public DateTime? RealizationDateTimeEnd { get; set; }

    public string CreateByUserId { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;

    public DateTime LastUpdateDateTime { get; set; }

    public bool IsApproved { get; set; }

    public string? ApproveByUserId { get; set; }

    public DateTime? ApproveDateTime { get; set; }

    public bool IsConfirmed { get; set; }

    public string? ConfirmByUserId { get; set; }

    public DateTime? ConfirmDateTime { get; set; }

    public bool IsVoid { get; set; }

    public string? VoidByUserId { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public bool IsRealized { get; set; }

    public string? RealizationApproveByUserId { get; set; }

    public DateTime? RealizationApproveDateTime { get; set; }

    public bool IsFromOrder { get; set; }

    public string? SrvehicleOrderType { get; set; }

    public string? RegistrationNo { get; set; }

    public string? RealizationNotes { get; set; }
}
