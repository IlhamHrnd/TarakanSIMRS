using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationRaspro
{
    public string RegistrationNo { get; set; }

    public int SeqNo { get; set; }

    public DateTime RasproDateTime { get; set; }

    public string Srraspro { get; set; }

    public string ParamedicId { get; set; }

    public string AdviseByParamedicId { get; set; }

    public string ServiceUnitId { get; set; }

    public string AbRestrictionId { get; set; }

    public int? ActionNo { get; set; }

    public int? AntibioticLevel { get; set; }

    public string ItemId { get; set; }

    public byte[] SignImage { get; set; }

    public string AntibioticIndication { get; set; }

    public string Comorbid { get; set; }

    public string ComorbidOther { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string SrwoundClassification { get; set; }

    public string SurgeryName { get; set; }

    public string PrescriptionNo { get; set; }

    public string Diagnose { get; set; }

    public string OtherInfection { get; set; }

    public string PrevAbRestrictionId { get; set; }

    public int? PrevAntibioticLevel { get; set; }

    public string ReferenceNo { get; set; }

    public bool? IsExternalCultureLabTest { get; set; }
}
