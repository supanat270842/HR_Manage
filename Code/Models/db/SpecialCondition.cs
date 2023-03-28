using System;
using System.Collections.Generic;

namespace HR_Management.Models.db;

public partial class SpecialCondition
{
    public int ScautoId { get; set; }

    public string MdepId { get; set; }

    public string ApbtypeId { get; set; }

    public string MempId { get; set; }

    public string MempName { get; set; }

    public string Scstatus { get; set; }

    public DateTime? SceditDate { get; set; }

    public string SceditBy { get; set; }

    public string Scremark { get; set; }
}
