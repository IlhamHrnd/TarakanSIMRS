using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicFeeVerificationRentalRoom
{
    public string VerificationNo { get; set; }

    public string TransactionNo { get; set; }

    public string SequenceNo { get; set; }

    public string TariffComponentId { get; set; }

    public decimal RentalRoomsAmount { get; set; }

    public decimal TogethernessAmount { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }
}
