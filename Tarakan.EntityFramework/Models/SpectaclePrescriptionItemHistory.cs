using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class SpectaclePrescriptionItemHistory
{
    public string RecalculationProcessNo { get; set; }

    public string PrescriptionNo { get; set; }

    public string SequenceNo { get; set; }

    public string ItemId { get; set; }

    public string SritemUnit { get; set; }

    public decimal Qty { get; set; }

    public decimal CostPrice { get; set; }

    public decimal InitialPrice { get; set; }

    public decimal Price { get; set; }

    public decimal DiscountAmount { get; set; }

    public string SrdiscountReason { get; set; }

    public string OdSphere { get; set; }

    public string OdCyl { get; set; }

    public string OdAxis { get; set; }

    public string OdPrism { get; set; }

    public string OdBase { get; set; }

    public string OdMpd { get; set; }

    public string OdPv { get; set; }

    public string OdSh { get; set; }

    public string OdAdd { get; set; }

    public string OsSphere { get; set; }

    public string OsCyl { get; set; }

    public string OsAxis { get; set; }

    public string OsPrism { get; set; }

    public string OsBase { get; set; }

    public string OsMpd { get; set; }

    public string OsPv { get; set; }

    public string OsSh { get; set; }

    public string OsAdd { get; set; }

    public string Notes { get; set; }

    public string FrameA { get; set; }

    public string FrameB { get; set; }

    public string Bridge { get; set; }

    public string FrameDia { get; set; }

    public bool IsVoid { get; set; }

    public bool IsBillProceed { get; set; }

    public bool IsApprove { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public decimal AutoProcessCalculation { get; set; }
}
