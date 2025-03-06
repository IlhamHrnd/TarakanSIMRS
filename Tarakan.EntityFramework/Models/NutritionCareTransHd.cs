using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class NutritionCareTransHd
{
    public string TransactionNo { get; set; }

    public DateTime NutritionCareTransDateTime { get; set; }

    public string RegistrationNo { get; set; }

    public string CreateByUserId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public string LastUpdateByUserId { get; set; }

    public DateTime LastUpdateDateTime { get; set; }
}
