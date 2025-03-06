namespace Tarakan.EntityFramework.Models;

public partial class ServiceRoom
{
    public string RoomId { get; set; }

    public string ServiceUnitId { get; set; }

    public string RoomName { get; set; }

    public string ItemId { get; set; }

    public string Notes { get; set; }

    public bool? IsOperatingRoom { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string ParamedicId1 { get; set; }

    public string ParamedicId2 { get; set; }

    public short? NumberOfBeds { get; set; }

    public string ItemBookedId { get; set; }

    public decimal? TariffDiscountForRoomIn { get; set; }

    public string Srfloor { get; set; }

    public bool? IsBpjs { get; set; }

    public string SrgenderType { get; set; }

    public bool? IsShowOnBookingOt { get; set; }

    public bool? IsResetPrice { get; set; }

    public bool? IsIsolationRoom { get; set; }

    public bool? IsNegativePressureRoom { get; set; }

    public bool? IsPandemicRoom { get; set; }

    public bool? IsVentilator { get; set; }

    public virtual ICollection<ServiceUnitBooking> ServiceUnitBookings { get; set; } = new List<ServiceUnitBooking>();
}
