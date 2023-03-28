using System;
using System.Collections.Generic;

namespace HR_Management.Models.db;

public partial class ConditionApproveBplu
{
    public int CabAutoId { get; set; }

    public TimeSpan? CabTimeStart { get; set; }

    public TimeSpan? CabTimeEnd { get; set; }

    public string CabStatus { get; set; }

    public int? BotAutoId { get; set; }

    public string BotName { get; set; }

    public DateTime? CabEditDate { get; set; }

    public string CabEditBy { get; set; }

    public string CabRemark { get; set; }
}
