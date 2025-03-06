using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class IntermBill
{
    public string IntermBillNo { get; set; }

    public DateTime IntermBillDate { get; set; }

    public string RegistrationNo { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public decimal PatientAmount { get; set; }

    public decimal GuarantorAmount { get; set; }

    public bool IsApproved { get; set; }

    public bool IsVoid { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string AskesCoveredSeqNo { get; set; }

    public string JournalIncomePaymentNo { get; set; }

    public decimal? AdministrationAmount { get; set; }

    public decimal? GuarantorAdministrationAmount { get; set; }

    public decimal? DiscAdmPatient { get; set; }

    public decimal? DiscAdmGuarantor { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string CreatedByUserId { get; set; }
}
