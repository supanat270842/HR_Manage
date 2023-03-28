using System;
using System.Collections.Generic;

namespace HR_Management.Models.db;

public partial class Rpaexcel
{
    public DateTime? HeaderQtdateStAffect { get; set; }

    public string ItemQtempId { get; set; }

    public string ItemQtempName { get; set; }

    public string ItemQttotalTime { get; set; }

    public string BotRemark { get; set; }
}
