﻿using System;
using System.Collections.Generic;

namespace HR_Management.Models.db;

public partial class RpacreateBplu
{
    public string HeaderQtdoc { get; set; }

    public string HeaderQtplant { get; set; }

    public string HeaderQtdep { get; set; }

    public DateTime? HeaderQtdateStAffect { get; set; }

    public DateTime? HeaderQtdateEnAffect { get; set; }

    public string HeaderQtdetailOt { get; set; }

    public string HeaderQtremark { get; set; }

    public int? SttKey { get; set; }

    public bool? HeaderQtcondition { get; set; }

    public string HeaderTypeOt { get; set; }

    public string HeaderConfirm { get; set; }

    public string ItemQtempId { get; set; }

    public string ItemQtempName { get; set; }

    public TimeSpan? ItemQttimeStAffect { get; set; }

    public TimeSpan? ItemQttimeEnAffect { get; set; }

    public string ItemQttotalTime { get; set; }

    public string ItemQtremark { get; set; }

    public string BplusDocNo { get; set; }

    public bool? ItemQtcondition { get; set; }

    public string ItemRpastatus { get; set; }

    public int? ApproveProcess { get; set; }

    public int? EmpKey { get; set; }
}
