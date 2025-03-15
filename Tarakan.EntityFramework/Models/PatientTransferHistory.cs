using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class PatientTransferHistory
{
    public string RegistrationNo { get; set; } = null!;

    public string TransferNo { get; set; } = null!;

    public string ServiceUnitId { get; set; } = null!;

    public string ClassId { get; set; } = null!;

    public string RoomId { get; set; } = null!;

    public string BedId { get; set; } = null!;

    public string ChargeClassId { get; set; } = null!;

    public DateTime? DateOfEntry { get; set; }

    public string? TimeOfEntry { get; set; }

    public DateTime? DateOfExit { get; set; }

    public string? TimeOfExit { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string? LastUpdateByUserId { get; set; }

    public string? SmfId { get; set; }

    public string? SmfIdbefore { get; set; }

    public DateTime? ArrivedDateTime { get; set; }

    public string? SrtransferredPatientWith { get; set; }

    public string? TransferredByUserId { get; set; }

    public string? ReceivedByUserId { get; set; }

    public string? FromServiceUnitId { get; set; }

    public string? FromClassId { get; set; }

    public string? FromRoomId { get; set; }

    public string? FromBedId { get; set; }

    public string? FromChargeClassId { get; set; }
}
