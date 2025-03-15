using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ParamedicFeeTransChargesItemComp
{
    public string TransactionNo { get; set; } = null!;

    public string SequenceNo { get; set; } = null!;

    public string TariffComponentId { get; set; } = null!;

    public DateOnly PhysicianFeePeriod { get; set; }

    public string ParamedicId { get; set; } = null!;

    public decimal PhysicianFeeAmount { get; set; }

    public decimal? IncPremi1Amount { get; set; }

    public decimal? IncPremi2Amount { get; set; }

    public decimal? DecProductionServicesAmount { get; set; }

    public decimal? DecTogethernessAmount { get; set; }

    public decimal? DecRentalRoomsAmount { get; set; }

    public string? RentalRoomsToParamedicId { get; set; }

    public string? VerificationNo { get; set; }

    public DateTime? LastCalculatedDateTime { get; set; }

    public string? LastCalculatedByUserId { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }

    public string? LastUpdatedByUserId { get; set; }
}
