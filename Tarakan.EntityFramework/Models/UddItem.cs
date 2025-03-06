﻿using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class UddItem
{
    public string RegistrationNo { get; set; }

    public string LocationId { get; set; }

    public string SequenceNo { get; set; }

    public string ParentNo { get; set; }

    public bool IsRflag { get; set; }

    public bool IsCompound { get; set; }

    public string ItemId { get; set; }

    public string SritemUnit { get; set; }

    public string ItemQtyInString { get; set; }

    public bool? IsUsingDosageUnit { get; set; }

    public string SrdosageUnit { get; set; }

    public byte? FrequencyOfDosing { get; set; }

    public string DosingPeriod { get; set; }

    public decimal? NumberOfDosage { get; set; }

    public byte? DurationOfDosing { get; set; }

    public string AcPcDc { get; set; }

    public string SrmedicationRoute { get; set; }

    public decimal PrescriptionQty { get; set; }

    public string EmbalaceId { get; set; }

    public bool? IsUseSweetener { get; set; }

    public string Notes { get; set; }

    public bool IsStop { get; set; }

    public string SrconsumeMethod { get; set; }

    public string DosageQty { get; set; }

    public string EmbalaceQty { get; set; }

    public string ConsumeQty { get; set; }

    public string SrconsumeUnit { get; set; }

    public DateTime LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? StartDateTime { get; set; }

    public DateTime? StopDateTime { get; set; }

    public int? RasproSeqNo { get; set; }

    public int? PrevRasproSeqNo { get; set; }

    public string PrevRasproItemId { get; set; }

    public int? RasprajaSeqNo { get; set; }

    public string ParamedicId { get; set; }
}
