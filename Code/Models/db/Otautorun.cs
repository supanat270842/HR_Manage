using System;
using System.Collections.Generic;

namespace HR_Management.Models.db;

public partial class Otautorun
{
    public int OtAutoId { get; set; }

    public int? OtId { get; set; }

    public string OtType { get; set; }

    public string OtYear { get; set; }

    public string OtPlant { get; set; }
}
