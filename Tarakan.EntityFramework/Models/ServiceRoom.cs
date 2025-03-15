using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ServiceRoom
{
    public string RoomId { get; set; } = null!;

    public string ServiceUnitId { get; set; } = null!;

    public string RoomName { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public bool? IsOperatingRoom { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? ParamedicId1 { get; set; }

    public string? ParamedicId2 { get; set; }

    public short? NumberOfBeds { get; set; }

    public string? ItemBookedId { get; set; }

    public decimal? TariffDiscountForRoomIn { get; set; }

    public string? Srfloor { get; set; }

    public bool? IsBpjs { get; set; }

    public string? SrgenderType { get; set; }

    public bool? IsShowOnBookingOt { get; set; }

    public bool? IsResetPrice { get; set; }

    public bool? IsIsolationRoom { get; set; }

    public bool? IsNegativePressureRoom { get; set; }

    public bool? IsPandemicRoom { get; set; }

    public bool? IsVentilator { get; set; }

    public int? ElectiveSurgeryQuotaDay1 { get; set; }

    public int? ElectiveSurgeryQuotaDay2 { get; set; }

    public int? ElectiveSurgeryQuotaDay3 { get; set; }

    public int? ElectiveSurgeryQuotaDay4 { get; set; }

    public int? ElectiveSurgeryQuotaDay5 { get; set; }

    public int? ElectiveSurgeryQuotaDay6 { get; set; }

    public int? ElectiveSurgeryQuotaDay7 { get; set; }

    public virtual ICollection<ServiceUnitBooking> ServiceUnitBookings { get; set; } = new List<ServiceUnitBooking>();
}
