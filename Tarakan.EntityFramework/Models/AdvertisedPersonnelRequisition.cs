using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class AdvertisedPersonnelRequisition
{
    public int AdvertisedPersonnelRequisitionId { get; set; }

    public int JobOpportunityId { get; set; }

    public int PersonnelRequisitionId { get; set; }

    public decimal EstimatedSalary { get; set; }

    public decimal MinimumEstimatedSalary { get; set; }

    public decimal MaximumEstimatedSalary { get; set; }

    public string JobDescription { get; set; }

    public string JobSpecification { get; set; }

    public string ContactPerson { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
