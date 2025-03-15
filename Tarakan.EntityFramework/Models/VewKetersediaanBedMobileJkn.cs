using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VewKetersediaanBedMobileJkn
{
    public string ServiceUnitId { get; set; } = null!;

    public string ServiceUnitName { get; set; } = null!;

    public string ClassId { get; set; } = null!;

    public string ClassName { get; set; } = null!;

    public string RoomId { get; set; } = null!;

    public string RoomName { get; set; } = null!;

    public int? Jumlah { get; set; }

    public int? M { get; set; }

    public int? F { get; set; }

    public int? Kosong { get; set; }

    public int? Isi { get; set; }
}
