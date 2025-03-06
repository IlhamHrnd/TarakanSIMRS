namespace Tarakan.EntityFramework.Models;

public partial class Patient
{
    public string PatientId { get; set; }

    public string MedicalNo { get; set; }

    public string Ssn { get; set; }

    public string Srsalutation { get; set; }

    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    public string LastName { get; set; }

    public string ParentSpouseName { get; set; }

    public string CityOfBirth { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string Sex { get; set; }

    public string SrbloodType { get; set; }

    public string BloodRhesus { get; set; }

    public string Srethnic { get; set; }

    public string Sreducation { get; set; }

    public string SrmaritalStatus { get; set; }

    public string Srnationality { get; set; }

    public string Sroccupation { get; set; }

    public string Srtitle { get; set; }

    public string SrpatientCategory { get; set; }

    public string Srreligion { get; set; }

    public string SrmedicalFileBin { get; set; }

    public string SrmedicalFileStatus { get; set; }

    public string GuarantorId { get; set; }

    public string Company { get; set; }

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

    public string TempAddressStreetName { get; set; }

    public string TempAddressDistrict { get; set; }

    public string TempAddressCity { get; set; }

    public string TempAddressCounty { get; set; }

    public string TempAddressState { get; set; }

    public string TempAddressZipCode { get; set; }

    public string TempAddressPhoneNo { get; set; }

    public DateTime? LastVisitDate { get; set; }

    public byte NumberOfVisit { get; set; }

    public string OldMedicalNo { get; set; }

    public string AccountNo { get; set; }

    public string PictureFileName { get; set; }

    public bool? IsDonor { get; set; }

    public decimal? NumberOfDonor { get; set; }

    public DateTime? LastDonorDate { get; set; }

    public bool IsBlackList { get; set; }

    public bool IsAlive { get; set; }

    public bool IsActive { get; set; }

    public string Notes { get; set; }

    public string DiagnosticNo { get; set; }

    public string MemberId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public decimal? PackageBalance { get; set; }

    public string HealthcareId { get; set; }

    public TimeOnly? ResponTime { get; set; }

    public string SrinformationFrom { get; set; }

    public string SrpatienRelation { get; set; }

    public int? PersonId { get; set; }

    public string EmployeeNumber { get; set; }

    public string SremployeeRelationship { get; set; }

    public string GuarantorCardNo { get; set; }

    public bool? IsNonPatient { get; set; }

    public short? ParentSpouseAge { get; set; }

    public string SrparentSpouseOccupation { get; set; }

    public string ParentSpouseOccupationDesc { get; set; }

    public string SrmotherOccupation { get; set; }

    public string MotherOccupationDesc { get; set; }

    public string MotherName { get; set; }

    public short? MotherAge { get; set; }

    public bool? IsNotPaidOff { get; set; }

    public string ParentSpouseMedicalNo { get; set; }

    public string MotherMedicalNo { get; set; }

    public string CompanyAddress { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string SrrelationshipQuality { get; set; }

    public string SrresidentialHome { get; set; }

    public bool? IsStoredToLokadok { get; set; }

    public string FatherName { get; set; }

    public short? FatherAge { get; set; }

    public string FatherMedicalNo { get; set; }

    public string SrfatherOccupation { get; set; }

    public string FatherOccupationDesc { get; set; }

    public string DeathCertificateNo { get; set; }

    public string EmployeeNo { get; set; }

    public string EmployeeJobTitleName { get; set; }

    public string EmployeeJobDepartementName { get; set; }

    public string ValuesOfTrust { get; set; }

    public DateTime? DeceasedDateTime { get; set; }

    public string FamilyRegisterNo { get; set; }

    public bool? IsSyncWithDukcapil { get; set; }

    public bool? IsDisability { get; set; }

    public string PassportNo { get; set; }

    public string Srbpjsclass { get; set; }

    public virtual PatientEmergencyContact PatientEmergencyContact { get; set; }

    public virtual ICollection<PatientInfo> PatientInfos { get; set; } = new List<PatientInfo>();
}
