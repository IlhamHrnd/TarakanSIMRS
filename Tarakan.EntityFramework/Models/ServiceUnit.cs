namespace Tarakan.EntityFramework.Models;

public partial class ServiceUnit
{
    public string ServiceUnitId { get; set; }

    public string DepartmentId { get; set; }

    public string ServiceUnitName { get; set; }

    public string ShortName { get; set; }

    public string ServiceUnitOfficer { get; set; }

    public string SrregistrationType { get; set; }

    public bool IsUsingJobOrder { get; set; }

    public bool IsPatientTransaction { get; set; }

    public bool IsTransactionEntry { get; set; }

    public bool? IsDispensaryUnit { get; set; }

    public bool? IsPurchasingUnit { get; set; }

    public bool IsGenerateMedicalNo { get; set; }

    public bool IsActive { get; set; }

    public int? ChartOfAccountIdIncome { get; set; }

    public int? SubledgerIdIncome { get; set; }

    public int? ChartOfAccountIdAcrual { get; set; }

    public int? SubledgerIdAcrual { get; set; }

    public int? ChartOfAccountIdDiscount { get; set; }

    public int? SubledgerIdDiscount { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public int? ChartOfAccountIdCost { get; set; }

    public int? SubledgerIdCost { get; set; }

    public bool? IsDirectPayment { get; set; }

    public int? ChartOfAccountIdCostNonMedic { get; set; }

    public int? SubledgerIdCostNonMedic { get; set; }

    public string SrgenderType { get; set; }

    public string ServiceUnitPharmacyId { get; set; }

    public int? ChartOfAccountIdCostParamedicFee { get; set; }

    public int? SubledgerIdCostParamedicFee { get; set; }

    public string SrassessmentType { get; set; }

    public bool? IsNeedConfirmationOfAttendance { get; set; }

    public string SrserviceUnitGroup { get; set; }

    public string LocationPharmacyId { get; set; }

    public string Email { get; set; }

    public string ServiceUnitPorId { get; set; }

    public string LocationPorId { get; set; }

    public int? ChartOfAccountIdPpnIn { get; set; }

    public int? SubledgerIdPpnIn { get; set; }

    public bool? IsShowOnKiosk { get; set; }

    public string DefaultChargeClassId { get; set; }

    public string CustomDisplay { get; set; }

    public bool? IsAllowAccessPatientWithServiceUnitParamedic { get; set; }

    public string MedicalFileFolderColor { get; set; }

    public string SrinpatientClassificationUnit { get; set; }

    public bool? IsHelpdesk { get; set; }

    public string Srbuilding { get; set; }

    public string SoundFilePath { get; set; }

    public string QueueCode { get; set; }

    public string SrqueueingLocationReg { get; set; }

    public string SrqueueingLocationPoli { get; set; }

    public string Srclassification { get; set; }

    public string SrclassificationRoom { get; set; }

    public string QueueName { get; set; }

    public virtual Department Department { get; set; }

    public virtual ICollection<ServiceUnitBooking> ServiceUnitBookings { get; set; } = new List<ServiceUnitBooking>();
}
