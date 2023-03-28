using System;
using System.Collections.Generic;

namespace HR_Management.Models.db;

public partial class ViewOverTime
{
    public string HeaderQtdoc { get; set; }

    public string HeaderQtrevise { get; set; }

    public string HeaderQtplant { get; set; }

    public string HeaderQtyard { get; set; }

    public string HeaderQtdep { get; set; }

    public DateTime? HeaderQtdateStAffect { get; set; }

    public string HeaderQtstatus { get; set; }

    public string ItemQtempId { get; set; }

    public string ItemQtempName { get; set; }

    public TimeSpan? ItemQttimeStAffect { get; set; }

    public TimeSpan? ItemQttimeEnAffect { get; set; }

    public string ItemQttotalTime { get; set; }
}
