using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class MedicalRecordFileBorrowed
{
    public string TransactionNo { get; set; }

    public string PatientId { get; set; }

    public string RegistrationNo { get; set; }

    public DateTime DateOfBorrowing { get; set; }

    public DateTime? DateOfReturn { get; set; }

    public string ServiceUnitId { get; set; }

    public string NameOfTheBorrower { get; set; }

    public string SrforThePurposesOf { get; set; }

    public string Notes { get; set; }

    public string NameOfRecipientId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string NameOfGivenId { get; set; }

    public string ReturnByName { get; set; }

    public short? Duration { get; set; }
}
