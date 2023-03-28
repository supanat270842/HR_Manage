using System;
using System.Collections.Generic;

namespace HR_Management.Models.dbCPS
{
    public partial class HeaderOt
    {
        public int HeaderQtid { get; set; }
        public string? HeaderQtdoc { get; set; }
        public string? HeaderQtrevise { get; set; }
        public string? HeaderQtplant { get; set; }
        public string? HeaderQtyard { get; set; }
        public string? HeaderQtdep { get; set; }
        public DateTime? HeaderQtdateStAffect { get; set; }
        public TimeSpan? HeaderQttimeStAffect { get; set; }
        public DateTime? HeaderQtdateEnAffect { get; set; }
        public TimeSpan? HeaderQttimeEnAffect { get; set; }
        public string? HeaderQthraffect { get; set; }
        public string? HeaderQtsumPersons { get; set; }
        public string? HeaderQtsumOt { get; set; }
        public string? HeaderQtdetailOt { get; set; }
        public string? HeaderQtleaderId { get; set; }
        public string? HeaderQttypeApprove { get; set; }
        public string? HeaderQtstatusApprove { get; set; }
        public string? HeaderQtremarkApprove { get; set; }
        public string? HeaderQtstatus { get; set; }
        public DateTime? HeaderQtcreateDate { get; set; }
        public string? HeaderQtcreateBy { get; set; }
        public DateTime? HeaderQteditDate { get; set; }
        public string? HeaderQteditBy { get; set; }
        public string? HeaderQtremark { get; set; }
        public string? HeaderQtnameYard { get; set; }
        public string? HeaderQtstatusTime { get; set; }
        public string? HeaderQtreviseHr { get; set; }
        public string? HeaderConfirm { get; set; }
        public string? HeaderTypeOt { get; set; }
        public bool? HeaderQtcondition { get; set; }
        public int? SttKey { get; set; }
    }
}
