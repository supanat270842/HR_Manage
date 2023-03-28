using System;
using System.Collections.Generic;

namespace HR_Management.Models.db;

public partial class View2
{
    public string ItemQtempId { get; set; }

    public string ItemQtempName { get; set; }

    public string ItemQttotalTime { get; set; }

    public int? SttKey { get; set; }

    public DateTime? Time { get; set; }

    public DateTime? HeaderQtdateStAffect { get; set; }
}
