using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwServiceUnitBooking
{
    public string BookingNo { get; set; }

    public string ParamedicId { get; set; }

    public string Medicalno { get; set; }

    public string PatientName { get; set; }

    public string Sex { get; set; }

    public string MobilePhoneNo { get; set; }

    public string ParamedicName { get; set; }

    public string ParamedicInitial { get; set; }

    public DateTime BookingDateTimeFrom { get; set; }

    public DateTime BookingDateTimeTo { get; set; }

    public string Weekdays { get; set; }

    public string PhoneNo { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string RoomId { get; set; }

    public string RoomName { get; set; }

    public string Notes { get; set; }

    public string AnestesiPlan { get; set; }
}
