﻿using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ApplicantPhysical
{
    public int ApplicantPhysicalId { get; set; }

    public int ApplicantId { get; set; }

    public string SrphysicalCharacteristic { get; set; }

    public string PhysicalValue { get; set; }

    public string SrmeasurementCode { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
