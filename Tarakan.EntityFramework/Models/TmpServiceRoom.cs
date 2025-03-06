using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpServiceRoom
{
    public string DepartmentId { get; set; }

    public string ServiceUnitId { get; set; }

    public string ServiceUnitName { get; set; }

    public string RoomId { get; set; }

    public string RoomName { get; set; }

    public double? ClassName { get; set; }

    public string SrgenderType { get; set; }

    public string BedId { get; set; }
}
