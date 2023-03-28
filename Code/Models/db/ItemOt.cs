using System;
using System.Collections.Generic;

namespace HR_Management.Models.db;

public partial class ItemOt
{
    public int ItemQtid { get; set; }

    public string ItemQtdoc { get; set; }

    public string ItemQtrevise { get; set; }

    public string ItemQtempId { get; set; }

    public string ItemQtempName { get; set; }

    public TimeSpan? ItemQttimeStAffect { get; set; }

    public TimeSpan? ItemQttimeEnAffect { get; set; }

    public string ItemQttotalTime { get; set; }

    public string ItemQtstatus { get; set; }

    public DateTime? ItemQtcreateDate { get; set; }

    public string ItemQtcreateBy { get; set; }

    public DateTime? ItemQteditDate { get; set; }

    public string ItemQteditBy { get; set; }

    public string ItemQtremark { get; set; }

    public string BplusDocNo { get; set; }

    public bool? ItemQtcondition { get; set; }

    public string ItemRpastatus { get; set; }

    public int? ApproveProcess { get; set; }

    public int? SaveBplusDone { get; set; }
}
