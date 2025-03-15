using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class Patient
{
    public string PatientId { get; set; } = null!;

    public string? MedicalNo { get; set; }

    public string Ssn { get; set; } = null!;

    public string Srsalutation { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? ParentSpouseName { get; set; }

    public string CityOfBirth { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public string Sex { get; set; } = null!;

    public string SrbloodType { get; set; } = null!;

    public string BloodRhesus { get; set; } = null!;

    public string Srethnic { get; set; } = null!;

    public string Sreducation { get; set; } = null!;

    public string SrmaritalStatus { get; set; } = null!;

    public string Srnationality { get; set; } = null!;

    public string Sroccupation { get; set; } = null!;

    public string Srtitle { get; set; } = null!;

    public string SrpatientCategory { get; set; } = null!;

    public string Srreligion { get; set; } = null!;

    public string SrmedicalFileBin { get; set; } = null!;

    public string SrmedicalFileStatus { get; set; } = null!;

    public string? GuarantorId { get; set; }

    public string? Company { get; set; }

    public string StreetName { get; set; } = null!;

    public string District { get; set; } = null!;

    public string City { get; set; } = null!;

    public string County { get; set; } = null!;

    public string State { get; set; } = null!;

    public string? ZipCode { get; set; }

    public string PhoneNo { get; set; } = null!;

    public string FaxNo { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string MobilePhoneNo { get; set; } = null!;

    public string? TempAddressStreetName { get; set; }

    public string? TempAddressDistrict { get; set; }

    public string? TempAddressCity { get; set; }

    public string? TempAddressCounty { get; set; }

    public string? TempAddressState { get; set; }

    public string? TempAddressZipCode { get; set; }

    public string? TempAddressPhoneNo { get; set; }

    public DateTime? LastVisitDate { get; set; }

    public byte NumberOfVisit { get; set; }

    public string OldMedicalNo { get; set; } = null!;

    public string AccountNo { get; set; } = null!;

    public string PictureFileName { get; set; } = null!;

    public bool? IsDonor { get; set; }

    public decimal? NumberOfDonor { get; set; }

    public DateTime? LastDonorDate { get; set; }

    public bool IsBlackList { get; set; }

    public bool IsAlive { get; set; }

    public bool IsActive { get; set; }

    public string? Notes { get; set; }

    public string? DiagnosticNo { get; set; }

    public string? MemberId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public decimal? PackageBalance { get; set; }

    public string? HealthcareId { get; set; }

    public TimeOnly? ResponTime { get; set; }

    public string? SrinformationFrom { get; set; }

    public string? SrpatienRelation { get; set; }

    public int? PersonId { get; set; }

    public string? EmployeeNumber { get; set; }

    public string? SremployeeRelationship { get; set; }

    public string? GuarantorCardNo { get; set; }

    public bool? IsNonPatient { get; set; }

    public short? ParentSpouseAge { get; set; }

    public string? SrparentSpouseOccupation { get; set; }

    public string? ParentSpouseOccupationDesc { get; set; }

    public string? SrmotherOccupation { get; set; }

    public string? MotherOccupationDesc { get; set; }

    public string? MotherName { get; set; }

    public short? MotherAge { get; set; }

    public bool? IsNotPaidOff { get; set; }

    public string? ParentSpouseMedicalNo { get; set; }

    public string? MotherMedicalNo { get; set; }

    public string? CompanyAddress { get; set; }

    public string? CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? SrrelationshipQuality { get; set; }

    public string? SrresidentialHome { get; set; }

    public bool? IsStoredToLokadok { get; set; }

    public string? FatherName { get; set; }

    public short? FatherAge { get; set; }

    public string? FatherMedicalNo { get; set; }

    public string? SrfatherOccupation { get; set; }

    public string? FatherOccupationDesc { get; set; }

    public string? DeathCertificateNo { get; set; }

    public string? EmployeeNo { get; set; }

    public string? EmployeeJobTitleName { get; set; }

    public string? EmployeeJobDepartementName { get; set; }

    public string? ValuesOfTrust { get; set; }

    public DateTime? DeceasedDateTime { get; set; }

    public string? FamilyRegisterNo { get; set; }

    public bool? IsSyncWithDukcapil { get; set; }

    public bool? IsDisability { get; set; }

    public string? PassportNo { get; set; }

    public string? Srbpjsclass { get; set; }

    public bool? IsAllowLogin { get; set; }

    public string? ReverseMedicalNo { get; set; }

    public string? ReverseOldMedicalNo { get; set; }

    public string? FullName { get; set; }

    public virtual PatientEmergencyContact? PatientEmergencyContact { get; set; }

    public virtual ICollection<PatientInfo> PatientInfos { get; set; } = new List<PatientInfo>();
}
