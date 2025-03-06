using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ApplicantInfo
{
    public int ApplicantId { get; set; }

    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    public string LastName { get; set; }

    public string SrapplicantStatus { get; set; }

    public DateTime DateApplied { get; set; }

    public DateTime? DateAvailable { get; set; }

    public int? ExpectedSalary { get; set; }

    public string SrcurrencyCode { get; set; }

    public string JobOpportunityReferenceNo { get; set; }

    public DateTime? SendRejectionDate { get; set; }

    public int? KeepOnFileDuration { get; set; }

    public string Note { get; set; }

    public string SrapplicantSource { get; set; }

    public string Address { get; set; }

    public string Srstate { get; set; }

    public string Srcity { get; set; }

    public string ZipCode { get; set; }

    public string PlaceBirth { get; set; }

    public DateTime BirthDate { get; set; }

    public string Ktpno { get; set; }

    public string SrgenderType { get; set; }

    public string Srreligion { get; set; }

    public string SrbloodType { get; set; }

    public string SrmaritalStatus { get; set; }

    public string Picture { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }
}
