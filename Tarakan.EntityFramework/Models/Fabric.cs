using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Fabric
{
    public string FabricId { get; set; }

    public string FabricName { get; set; }

    public string ShortName { get; set; }

    public string ContractNumber { get; set; }

    public DateTime? ContractStart { get; set; }

    public DateTime? ContractEnd { get; set; }

    public string ContractSummary { get; set; }

    public string ContactPerson { get; set; }

    public bool IsPkp { get; set; }

    public string TaxRegistrationNo { get; set; }

    public bool IsActive { get; set; }

    public string StreetName { get; set; }

    public string District { get; set; }

    public string City { get; set; }

    public string County { get; set; }

    public string State { get; set; }

    public string ZipCode { get; set; }

    public string PhoneNo { get; set; }

    public string FaxNo { get; set; }

    public string Email { get; set; }

    public string MobilePhoneNo { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public virtual ICollection<SupplierFabric> SupplierFabrics { get; set; } = new List<SupplierFabric>();
}
