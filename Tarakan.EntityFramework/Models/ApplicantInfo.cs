using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ApplicantInfo
{
    public int ApplicantId { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string SrapplicantStatus { get; set; } = null!;

    public DateTime DateApplied { get; set; }

    public DateTime? DateAvailable { get; set; }

    public int? ExpectedSalary { get; set; }

    public string? SrcurrencyCode { get; set; }

    public string? JobOpportunityReferenceNo { get; set; }

    public DateTime? SendRejectionDate { get; set; }

    public int? KeepOnFileDuration { get; set; }

    public string? Note { get; set; }

    public string? SrapplicantSource { get; set; }

    public string Address { get; set; } = null!;

    public string Srstate { get; set; } = null!;

    public string? Srcity { get; set; }

    public string? ZipCode { get; set; }

    public string? PlaceBirth { get; set; }

    public DateTime BirthDate { get; set; }

    public string? Ktpno { get; set; }

    public string SrgenderType { get; set; } = null!;

    public string Srreligion { get; set; } = null!;

    public string? SrbloodType { get; set; }

    public string SrmaritalStatus { get; set; } = null!;

    public string? Picture { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; } = null!;
}
