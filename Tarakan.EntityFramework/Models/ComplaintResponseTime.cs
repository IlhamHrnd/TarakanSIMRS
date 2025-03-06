using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ComplaintResponseTime
{
    public string ComplaintNo { get; set; }

    public DateTime ComplaintDate { get; set; }

    public string CustomerName { get; set; }

    public string PatientId { get; set; }

    public string CustomerAddress { get; set; }

    public string ServiceUnitId { get; set; }

    public string PhoneNo { get; set; }

    public string ComplaintDescription { get; set; }

    public string SrcomplaintRiskGrading { get; set; }

    public DateTime? ReportReceivedMarketingDate { get; set; }

    public string ReportReceivedMarketingBy { get; set; }

    public DateTime? ReportReceivedUnitDate { get; set; }

    public string ReportReceivedUnitBy { get; set; }

    public DateTime? CorrectiveActionDate { get; set; }

    public string CorrectiveActionBy { get; set; }

    public string CorrectiveAction { get; set; }

    public string PreventiveAction { get; set; }

    public bool? IsApproved { get; set; }

    public DateTime? ApprovedDateTime { get; set; }

    public string ApprovedByUserId { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string VoidByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
