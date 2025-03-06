namespace Tarakan.EntityFramework.Models;

public partial class AppUser
{
    public string UserId { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public string Srlanguage { get; set; }

    public DateTime ActiveDate { get; set; }

    public DateTime ExpireDate { get; set; }

    public DateTime? LastUpdateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public string ParamedicId { get; set; }

    public string ServiceUnitId { get; set; }

    public string LicenseNo { get; set; }

    public int? PersonId { get; set; }

    public string Email { get; set; }

    public bool? IsLocked { get; set; }

    public string SruserType { get; set; }

    public string CashManagementNo { get; set; }

    public byte[] SignatureImage { get; set; }

    public string LastCounterName { get; set; }

    public string PasswordMd5 { get; set; }

    public DateTime? LastLogin { get; set; }

    public string EsignNik { get; set; }
}
