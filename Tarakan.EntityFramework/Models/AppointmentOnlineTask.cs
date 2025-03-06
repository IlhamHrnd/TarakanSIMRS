using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AppointmentOnlineTask
{
    public string AppointmentNo { get; set; }

    public string TaskId { get; set; }

    public string Timestamp { get; set; }

    public DateTime? LastUpdatedDate { get; set; }

    public bool? IsSended { get; set; }

    public byte? Attempt { get; set; }

    public bool? IsError { get; set; }

    public bool? IsTaskOneDone { get; set; }

    public string TaskOneTimestamp { get; set; }

    public bool? IsTaskTwoDone { get; set; }

    public string TaskTwoTimestamp { get; set; }

    public bool? IsTaskThreeDone { get; set; }

    public string TaskThreeTimestamp { get; set; }

    public bool? IsTaskFourDone { get; set; }

    public string TaskFourTimestamp { get; set; }

    public bool? IsTaskFiveDone { get; set; }

    public string TaskFiveTimestamp { get; set; }

    public bool? IsTaskSixDone { get; set; }

    public string TaskSixTimestamp { get; set; }

    public bool? IsTaskSevenDone { get; set; }

    public string TaskSevenTimestamp { get; set; }

    public bool? IsTaskEightDone { get; set; }

    public string TaskEightTimestamp { get; set; }

    public bool? IsTaskNineDone { get; set; }

    public string TaskNineTimestamp { get; set; }

    public bool? IsTaskTenDone { get; set; }

    public string TaskTenTimestamp { get; set; }
}
