using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class RegistrationInfoMedical
{
    public long Id { get; set; }

    public string RegistrationNo { get; set; }

    public string SrmedicalNotesInputType { get; set; }

    public DateTime DateTimeInfo { get; set; }

    public string Info1 { get; set; }

    public string Info2 { get; set; }

    public string Info3 { get; set; }

    public string Info4 { get; set; }

    public string CreatedByUserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public virtual Registration RegistrationNoNavigation { get; set; }
}
