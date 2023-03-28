using System;
using System.Collections.Generic;

namespace HR_Management.Models.db;

public partial class Apidetail
{
    public string HeaderQtdoc { get; set; }

    public string BotRemark { get; set; }

    public string HeaderTypeOt { get; set; }

    public string ItemQtempId { get; set; }

    public string ItemQtempName { get; set; }

    public DateTime? HeaderQtdateStAffect { get; set; }

    public TimeSpan? ItemQttimeStAffect { get; set; }

    public TimeSpan? ItemQttimeEnAffect { get; set; }

    public string ItemQttotalTime { get; set; }

    public string HeaderQtdetailOt { get; set; }
}
