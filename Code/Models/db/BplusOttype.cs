using System;
using System.Collections.Generic;

namespace HR_Management.Models.db;

public partial class BplusOttype
{
    public int BotAutoId { get; set; }

    public int? SttKey { get; set; }

    public string BotName { get; set; }

    public string BotStatus { get; set; }

    public DateTime? BotEditDate { get; set; }

    public string BotEditBy { get; set; }

    public string BotRemark { get; set; }
}
