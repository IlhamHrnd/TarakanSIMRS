using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class BloodBankTransactionItem
{
    public string TransactionNo { get; set; }

    public string BagNo { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public string ReceivedTime { get; set; }

    public string SrbloodGroupReceived { get; set; }

    public string SrbloodBagStatus { get; set; }

    public bool? IsScreeningLabelPassedPmi { get; set; }

    public bool? IsExpiredDate { get; set; }

    public bool? IsLeak { get; set; }

    public bool? IsHemolysis { get; set; }

    public bool? IsCrossMatchingSuitability { get; set; }

    public bool? IsClotting { get; set; }

    public bool? IsBloodTypeCompatibility { get; set; }

    public bool? IsLabelDonorsMatchesWithPatientsForm { get; set; }

    public bool? IsScreeningLabelPassedBd { get; set; }

    public string ExaminerByUserId { get; set; }

    public string UnitOfficer { get; set; }

    public DateTime? TransfusionStartDateTime { get; set; }

    public DateTime? TransfusionEndDateTime { get; set; }

    public string TransfusedOfficerStartBy { get; set; }

    public string TransfusedOfficerEndBy { get; set; }

    public short? QtyTransfusion { get; set; }

    public string SrbloodSource { get; set; }

    public string SrbloodSourceFrom { get; set; }

    public string CrossmatchCompatibleMajor { get; set; }

    public string CrossmatchCompatibleMinor { get; set; }

    public short? CrossmatchCompatibleMinorLevel { get; set; }

    public string CrossmatchCompatibleAutoControl { get; set; }

    public short? CrossmatchCompatibleAutoControlLevel { get; set; }

    public string CrossmatchCompatibleDctControl { get; set; }

    public short? CrossmatchCompatibleDctControlLevel { get; set; }

    public DateTime? CrossmatchStartDateTime { get; set; }

    public DateTime? CrossmatchEndDateTime { get; set; }

    public bool? IsCrossmatchingPassed { get; set; }

    public string CrossMatchingByUserId { get; set; }

    public decimal? BloodBagTemperature { get; set; }

    public string BloodBagNotes { get; set; }

    public bool? IsProceedToTransfusion { get; set; }

    public string BpPre { get; set; }

    public string Bp10 { get; set; }

    public string Bp30 { get; set; }

    public string Bp60 { get; set; }

    public string Bp120 { get; set; }

    public string Bp180 { get; set; }

    public string Bp240 { get; set; }

    public string BpPost { get; set; }

    public string BpPost2 { get; set; }

    public string BpPost3 { get; set; }

    public decimal? PulsePre { get; set; }

    public decimal? Pulse10 { get; set; }

    public decimal? Pulse30 { get; set; }

    public decimal? Pulse60 { get; set; }

    public decimal? Pulse120 { get; set; }

    public decimal? Pulse180 { get; set; }

    public decimal? Pulse240 { get; set; }

    public decimal? PulsePost { get; set; }

    public decimal? PulsePost2 { get; set; }

    public decimal? PulsePost3 { get; set; }

    public decimal? TemperaturePre { get; set; }

    public decimal? Temperature10 { get; set; }

    public decimal? Temperature30 { get; set; }

    public decimal? Temperature60 { get; set; }

    public decimal? Temperature120 { get; set; }

    public decimal? Temperature180 { get; set; }

    public decimal? Temperature240 { get; set; }

    public decimal? TemperaturePost { get; set; }

    public decimal? TemperaturePost2 { get; set; }

    public decimal? TemperaturePost3 { get; set; }

    public decimal? RespiratoryPre { get; set; }

    public decimal? Respiratory10 { get; set; }

    public decimal? Respiratory30 { get; set; }

    public decimal? Respiratory60 { get; set; }

    public decimal? Respiratory120 { get; set; }

    public decimal? Respiratory180 { get; set; }

    public decimal? Respiratory240 { get; set; }

    public decimal? RespiratoryPost { get; set; }

    public decimal? RespiratoryPost2 { get; set; }

    public decimal? RespiratoryPost3 { get; set; }

    public bool? IsFeverPre { get; set; }

    public bool? IsFever10 { get; set; }

    public bool? IsFever30 { get; set; }

    public bool? IsFever60 { get; set; }

    public bool? IsFever120 { get; set; }

    public bool? IsFever180 { get; set; }

    public bool? IsFever240 { get; set; }

    public bool? IsFeverPost { get; set; }

    public bool? IsFeverPost2 { get; set; }

    public bool? IsFeverPost3 { get; set; }

    public bool? IsShiveringPre { get; set; }

    public bool? IsShivering10 { get; set; }

    public bool? IsShivering30 { get; set; }

    public bool? IsShivering60 { get; set; }

    public bool? IsShivering120 { get; set; }

    public bool? IsShivering180 { get; set; }

    public bool? IsShivering240 { get; set; }

    public bool? IsShiveringPost { get; set; }

    public bool? IsShiveringPost2 { get; set; }

    public bool? IsShiveringPost3 { get; set; }

    public bool? IsSobPre { get; set; }

    public bool? IsSob10 { get; set; }

    public bool? IsSob30 { get; set; }

    public bool? IsSob60 { get; set; }

    public bool? IsSob120 { get; set; }

    public bool? IsSob180 { get; set; }

    public bool? IsSob240 { get; set; }

    public bool? IsSobPost { get; set; }

    public bool? IsSobPost2 { get; set; }

    public bool? IsSobPost3 { get; set; }

    public bool? IsPainfulPre { get; set; }

    public bool? IsPainful10 { get; set; }

    public bool? IsPainful30 { get; set; }

    public bool? IsPainful60 { get; set; }

    public bool? IsPainful120 { get; set; }

    public bool? IsPainful180 { get; set; }

    public bool? IsPainful240 { get; set; }

    public bool? IsPainfulPost { get; set; }

    public bool? IsPainfulPost2 { get; set; }

    public bool? IsPainfulPost3 { get; set; }

    public bool? IsNauseaPre { get; set; }

    public bool? IsNausea10 { get; set; }

    public bool? IsNausea30 { get; set; }

    public bool? IsNausea60 { get; set; }

    public bool? IsNausea120 { get; set; }

    public bool? IsNausea180 { get; set; }

    public bool? IsNausea240 { get; set; }

    public bool? IsNauseaPost { get; set; }

    public bool? IsNauseaPost2 { get; set; }

    public bool? IsNauseaPost3 { get; set; }

    public bool? IsBleedingPre { get; set; }

    public bool? IsBleeding10 { get; set; }

    public bool? IsBleeding30 { get; set; }

    public bool? IsBleeding60 { get; set; }

    public bool? IsBleeding120 { get; set; }

    public bool? IsBleeding180 { get; set; }

    public bool? IsBleeding240 { get; set; }

    public bool? IsBleedingPost { get; set; }

    public bool? IsBleedingPost2 { get; set; }

    public bool? IsBleedingPost3 { get; set; }

    public bool? IsHypotensionPre { get; set; }

    public bool? IsHypotension10 { get; set; }

    public bool? IsHypotension30 { get; set; }

    public bool? IsHypotension60 { get; set; }

    public bool? IsHypotension120 { get; set; }

    public bool? IsHypotension180 { get; set; }

    public bool? IsHypotension240 { get; set; }

    public bool? IsHypotensionPost { get; set; }

    public bool? IsHypotensionPost2 { get; set; }

    public bool? IsHypotensionPost3 { get; set; }

    public bool? IsShockPre { get; set; }

    public bool? IsShock10 { get; set; }

    public bool? IsShock30 { get; set; }

    public bool? IsShock60 { get; set; }

    public bool? IsShock120 { get; set; }

    public bool? IsShock180 { get; set; }

    public bool? IsShock240 { get; set; }

    public bool? IsShockPost { get; set; }

    public bool? IsShockPost2 { get; set; }

    public bool? IsShockPost3 { get; set; }

    public bool? IsUrticariaPre { get; set; }

    public bool? IsUrticaria10 { get; set; }

    public bool? IsUrticaria30 { get; set; }

    public bool? IsUrticaria60 { get; set; }

    public bool? IsUrticaria120 { get; set; }

    public bool? IsUrticaria180 { get; set; }

    public bool? IsUrticaria240 { get; set; }

    public bool? IsUrticariaPost { get; set; }

    public bool? IsUrticariaPost2 { get; set; }

    public bool? IsUrticariaPost3 { get; set; }

    public bool? IsRashPre { get; set; }

    public bool? IsRash10 { get; set; }

    public bool? IsRash30 { get; set; }

    public bool? IsRash60 { get; set; }

    public bool? IsRash120 { get; set; }

    public bool? IsRash180 { get; set; }

    public bool? IsRash240 { get; set; }

    public bool? IsRashPost { get; set; }

    public bool? IsRashPost2 { get; set; }

    public bool? IsRashPost3 { get; set; }

    public bool? IsPruritusPre { get; set; }

    public bool? IsPruritus10 { get; set; }

    public bool? IsPruritus30 { get; set; }

    public bool? IsPruritus60 { get; set; }

    public bool? IsPruritus120 { get; set; }

    public bool? IsPruritus180 { get; set; }

    public bool? IsPruritus240 { get; set; }

    public bool? IsPruritusPost { get; set; }

    public bool? IsPruritusPost2 { get; set; }

    public bool? IsPruritusPost3 { get; set; }

    public bool? IsAnxiousPre { get; set; }

    public bool? IsAnxious10 { get; set; }

    public bool? IsAnxious30 { get; set; }

    public bool? IsAnxious60 { get; set; }

    public bool? IsAnxious120 { get; set; }

    public bool? IsAnxious180 { get; set; }

    public bool? IsAnxious240 { get; set; }

    public bool? IsAnxiousPost { get; set; }

    public bool? IsAnxiousPost2 { get; set; }

    public bool? IsAnxiousPost3 { get; set; }

    public bool? IsWeakPre { get; set; }

    public bool? IsWeak10 { get; set; }

    public bool? IsWeak30 { get; set; }

    public bool? IsWeak60 { get; set; }

    public bool? IsWeak120 { get; set; }

    public bool? IsWeak180 { get; set; }

    public bool? IsWeak240 { get; set; }

    public bool? IsWeakPost { get; set; }

    public bool? IsWeakPost2 { get; set; }

    public bool? IsWeakPost3 { get; set; }

    public bool? IsPalpitationsPre { get; set; }

    public bool? IsPalpitations10 { get; set; }

    public bool? IsPalpitations30 { get; set; }

    public bool? IsPalpitations60 { get; set; }

    public bool? IsPalpitations120 { get; set; }

    public bool? IsPalpitations180 { get; set; }

    public bool? IsPalpitations240 { get; set; }

    public bool? IsPalpitationsPost { get; set; }

    public bool? IsPalpitationsPost2 { get; set; }

    public bool? IsPalpitationsPost3 { get; set; }

    public bool? IsMildDyspneaPre { get; set; }

    public bool? IsMildDyspnea10 { get; set; }

    public bool? IsMildDyspnea30 { get; set; }

    public bool? IsMildDyspnea60 { get; set; }

    public bool? IsMildDyspnea120 { get; set; }

    public bool? IsMildDyspnea180 { get; set; }

    public bool? IsMildDyspnea240 { get; set; }

    public bool? IsMildDyspneaPost { get; set; }

    public bool? IsMildDyspneaPost2 { get; set; }

    public bool? IsMildDyspneaPost3 { get; set; }

    public bool? IsHeadachePre { get; set; }

    public bool? IsHeadache10 { get; set; }

    public bool? IsHeadache30 { get; set; }

    public bool? IsHeadache60 { get; set; }

    public bool? IsHeadache120 { get; set; }

    public bool? IsHeadache180 { get; set; }

    public bool? IsHeadache240 { get; set; }

    public bool? IsHeadachePost { get; set; }

    public bool? IsHeadachePost2 { get; set; }

    public bool? IsHeadachePost3 { get; set; }

    public bool? IsRednessOnTheSkinPre { get; set; }

    public bool? IsRednessOnTheSkin10 { get; set; }

    public bool? IsRednessOnTheSkin30 { get; set; }

    public bool? IsRednessOnTheSkin60 { get; set; }

    public bool? IsRednessOnTheSkin120 { get; set; }

    public bool? IsRednessOnTheSkin180 { get; set; }

    public bool? IsRednessOnTheSkin240 { get; set; }

    public bool? IsRednessOnTheSkinPost { get; set; }

    public bool? IsRednessOnTheSkinPost2 { get; set; }

    public bool? IsRednessOnTheSkinPost3 { get; set; }

    public bool? IsTachycardiaPre { get; set; }

    public bool? IsTachycardia10 { get; set; }

    public bool? IsTachycardia30 { get; set; }

    public bool? IsTachycardia60 { get; set; }

    public bool? IsTachycardia120 { get; set; }

    public bool? IsTachycardia180 { get; set; }

    public bool? IsTachycardia240 { get; set; }

    public bool? IsTachycardiaPost { get; set; }

    public bool? IsTachycardiaPost2 { get; set; }

    public bool? IsTachycardiaPost3 { get; set; }

    public bool? IsMuscleStiffnessPre { get; set; }

    public bool? IsMuscleStiffness10 { get; set; }

    public bool? IsMuscleStiffness30 { get; set; }

    public bool? IsMuscleStiffness60 { get; set; }

    public bool? IsMuscleStiffness120 { get; set; }

    public bool? IsMuscleStiffness180 { get; set; }

    public bool? IsMuscleStiffness240 { get; set; }

    public bool? IsMuscleStiffnessPost { get; set; }

    public bool? IsMuscleStiffnessPost2 { get; set; }

    public bool? IsMuscleStiffnessPost3 { get; set; }

    public string OtherReactionPre { get; set; }

    public string OtherReaction10 { get; set; }

    public string OtherReaction30 { get; set; }

    public string OtherReaction60 { get; set; }

    public string OtherReaction120 { get; set; }

    public string OtherReaction180 { get; set; }

    public string OtherReaction240 { get; set; }

    public string OtherReactionPost { get; set; }

    public string OtherReactionPost2 { get; set; }

    public string OtherReactionPost3 { get; set; }

    public decimal? HemoglobinPre { get; set; }

    public decimal? Hemoglobin10 { get; set; }

    public decimal? Hemoglobin30 { get; set; }

    public decimal? Hemoglobin60 { get; set; }

    public decimal? Hemoglobin120 { get; set; }

    public decimal? Hemoglobin180 { get; set; }

    public decimal? Hemoglobin240 { get; set; }

    public decimal? HemoglobinPost { get; set; }

    public decimal? HemoglobinPost2 { get; set; }

    public decimal? HemoglobinPost3 { get; set; }

    public decimal? HematocritPre { get; set; }

    public decimal? Hematocrit10 { get; set; }

    public decimal? Hematocrit30 { get; set; }

    public decimal? Hematocrit60 { get; set; }

    public decimal? Hematocrit120 { get; set; }

    public decimal? Hematocrit180 { get; set; }

    public decimal? Hematocrit240 { get; set; }

    public decimal? HematocritPost { get; set; }

    public decimal? HematocritPost2 { get; set; }

    public decimal? HematocritPost3 { get; set; }

    public decimal? PlateletPre { get; set; }

    public decimal? Platelet10 { get; set; }

    public decimal? Platelet30 { get; set; }

    public decimal? Platelet60 { get; set; }

    public decimal? Platelet120 { get; set; }

    public decimal? Platelet180 { get; set; }

    public decimal? Platelet240 { get; set; }

    public decimal? PlateletPost { get; set; }

    public decimal? PlateletPost2 { get; set; }

    public decimal? PlateletPost3 { get; set; }

    public string ActionPre { get; set; }

    public string Action10 { get; set; }

    public string Action30 { get; set; }

    public string Action60 { get; set; }

    public string Action120 { get; set; }

    public string Action180 { get; set; }

    public string Action240 { get; set; }

    public string ActionPost { get; set; }

    public string ActionPost2 { get; set; }

    public string ActionPost3 { get; set; }

    public bool? IsHiv { get; set; }

    public bool? IsVbrl { get; set; }

    public bool? IsHbsAg { get; set; }

    public bool? IsHcv { get; set; }

    public bool? IsReCheck { get; set; }

    public DateTime? ReCheckDateTime { get; set; }

    public bool? IsReCheckExpiredDate { get; set; }

    public bool? IsReCheckLeak { get; set; }

    public bool? IsReCheckHemolysis { get; set; }

    public bool? IsReCheckCrossMatchingSuitability { get; set; }

    public bool? IsReCheckClotting { get; set; }

    public bool? IsReCheckBloodTypeCompatibility { get; set; }

    public string ReCheckOfficer { get; set; }

    public string ReCheckOfficer2 { get; set; }

    public string Notes { get; set; }

    public bool? IsCrossmatchBillProceed { get; set; }

    public bool? IsTransfusionBillProceed { get; set; }

    public bool? IsVoid { get; set; }

    public DateTime? VoidDateTime { get; set; }

    public string VoidByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public bool? IsScreening1 { get; set; }

    public bool? IsScreening2 { get; set; }

    public bool? IsScreening3 { get; set; }

    public string UnitOfficerByUserId { get; set; }
}
