using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class VwMr
{
    public string MedicalNo { get; set; }

    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    public DateTime RegistrationDate { get; set; }

    public string StreetName { get; set; }

    public string KdKecamatan { get; set; }

    public string PhoneNo { get; set; }

    public string ZipCode { get; set; }

    public string CityOfBirth { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string JnsKelamin { get; set; }

    public string StatusNikah { get; set; }

    public string Warganegara { get; set; }

    public string Agama { get; set; }

    public string GolDarah { get; set; }

    public string Suku { get; set; }

    public string Pendidikan { get; set; }

    public string Pekerjaan { get; set; }

    public string MrSaudara { get; set; }

    public string HubSaudara { get; set; }

    public string UserId { get; set; }

    public string LastUpdateByUserId { get; set; }
}
