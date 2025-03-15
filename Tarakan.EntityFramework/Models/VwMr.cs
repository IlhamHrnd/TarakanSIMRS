using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwMr
{
    public string? MedicalNo { get; set; }

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public DateTime RegistrationDate { get; set; }

    public string StreetName { get; set; } = null!;

    public string KdKecamatan { get; set; } = null!;

    public string PhoneNo { get; set; } = null!;

    public string? ZipCode { get; set; }

    public string CityOfBirth { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public string JnsKelamin { get; set; } = null!;

    public string StatusNikah { get; set; } = null!;

    public string Warganegara { get; set; } = null!;

    public string Agama { get; set; } = null!;

    public string GolDarah { get; set; } = null!;

    public string Suku { get; set; } = null!;

    public string Pendidikan { get; set; } = null!;

    public string Pekerjaan { get; set; } = null!;

    public string MrSaudara { get; set; } = null!;

    public string HubSaudara { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string? LastUpdateByUserId { get; set; }
}
