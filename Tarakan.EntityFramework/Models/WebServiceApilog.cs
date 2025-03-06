using System;
using System.Collections.Generic;

namespace Tarakan.EntityFramework.Models;

public partial class WebServiceApilog
{
    public int Id { get; set; }

    public DateTime? DateRequest { get; set; }

    public string Ipaddress { get; set; }

    public string UrlAddress { get; set; }

    public string Params { get; set; }

    public string Response { get; set; }

    public int? Totalms { get; set; }
}
