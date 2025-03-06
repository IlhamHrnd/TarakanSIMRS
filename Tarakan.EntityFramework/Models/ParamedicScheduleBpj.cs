using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicScheduleBpj
{
    public string BpjsParamedicId { get; set; }

    public string BpjsServiceUnitId { get; set; }

    public string BpjsDay { get; set; }

    public string BpjsDayName { get; set; }

    public DateTime BpjsScheduleDate { get; set; }

    public string BpjsParamedicName { get; set; }

    public string BpjsStartHour { get; set; }

    public string BpjsEndHour { get; set; }

    public int? BpjsMaxCapacity { get; set; }

    public string BpjsSubSpecialityCode { get; set; }

    public string BpjsSubSpecialityName { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string IsActive { get; set; }

    public string ParamedicId { get; set; }
}
