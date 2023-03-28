using System;
using System.Collections.Generic;

namespace HR_Management.Models.db;

public partial class ConfigCheckinTime
{
    public int CtAutoId { get; set; }

    public int? CtDifferentTime { get; set; }

    public string CtStatus { get; set; }

    public string CtCreateBy { get; set; }

    public DateTime? CtCreateDate { get; set; }

    public string CtEditBy { get; set; }

    public DateTime? CtEditDate { get; set; }

    public string CtRemark { get; set; }
}
