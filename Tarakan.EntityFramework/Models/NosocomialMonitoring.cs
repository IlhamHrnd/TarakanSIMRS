using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NosocomialMonitoring
{
    public string RegistrationNo { get; set; } = null!;

    public int MonitoringNo { get; set; }

    public string MonitoringType { get; set; } = null!;

    public DateTime InstallationDateTime { get; set; }

    public DateTime? ReleaseDateTime { get; set; }

    public string? RoomId { get; set; }

    public string? Location { get; set; }

    public string? TypeOfInfus { get; set; }

    public string? FluidOther { get; set; }

    public string? TypeOfCatheter { get; set; }

    public string? Antibiotic { get; set; }

    public string? Problem { get; set; }

    public string? Monitoring { get; set; }

    public string? TubeNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? SrettType { get; set; }

    public string? DecubitusFromType { get; set; }

    public string? DecubitusFrom { get; set; }

    public string? OtherDrugs { get; set; }

    public decimal? BodyWeight { get; set; }

    public string? VentilationMode { get; set; }

    public int? TidalVolume { get; set; }

    public int? RespirationRate { get; set; }

    public int? FiO2 { get; set; }

    public int? Peep { get; set; }

    public int? PeakFlow { get; set; }

    public string? Sensitivity { get; set; }

    public string? InstallationByUserId { get; set; }

    public string? ReleaseByUserId { get; set; }

    public string? ReferenceNo { get; set; }

    public string? ServiceUnitId { get; set; }

    public DateTime? DecubitusDateTime { get; set; }

    public string? Srivcatheter { get; set; }

    public string? SrinfusSet { get; set; }

    public bool? IsSetBlood { get; set; }
}
