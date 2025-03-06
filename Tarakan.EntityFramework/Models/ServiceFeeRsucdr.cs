using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class ServiceFeeRsucdr
{
    public string TransactionNo { get; set; }

    public string SequenceNo { get; set; }

    public string TariffComponentId { get; set; }

    public string RegistrationNo { get; set; }

    public decimal FeeDirektur { get; set; }

    public decimal FeeStruktural { get; set; }

    public decimal FeeMedis { get; set; }

    public decimal FeeUnit { get; set; }

    public decimal FeePemerataan { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime? CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public bool? IsParamedicFeeRemun { get; set; }

    public bool? IsParamedicEmergency { get; set; }

    public int RemunId { get; set; }
}
