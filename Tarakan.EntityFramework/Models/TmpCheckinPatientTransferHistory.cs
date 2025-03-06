using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class TmpCheckinPatientTransferHistory
{
    public string RegistrationNo { get; set; }

    public string TransferNo { get; set; }

    public string ServiceUnitId { get; set; }

    public string ClassId { get; set; }

    public string RoomId { get; set; }

    public string BedId { get; set; }

    public string ChargeClassId { get; set; }

    public DateTime? DateOfEntry { get; set; }

    public string TimeOfEntry { get; set; }

    public DateTime? DateOfExit { get; set; }

    public string TimeOfExit { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string SmfId { get; set; }

    public string SmfIdbefore { get; set; }

    public DateTime? ArrivedDateTime { get; set; }

    public string SrtransferredPatientWith { get; set; }

    public string TransferredByUserId { get; set; }

    public string ReceivedByUserId { get; set; }

    public string FromServiceUnitId { get; set; }

    public string FromClassId { get; set; }

    public string FromRoomId { get; set; }

    public string FromBedId { get; set; }

    public string FromChargeClassId { get; set; }

    public Guid CopyId { get; set; }
}
