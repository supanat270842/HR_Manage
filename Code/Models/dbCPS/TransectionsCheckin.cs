using System;
using System.Collections.Generic;

namespace HR_Management.Models.dbCPS
{
    public partial class TransectionsCheckin
    {
        public int TrAutoId { get; set; }
        public string? HeaderQtdoc { get; set; }
        public TimeSpan? TrTimeCheckin { get; set; }
        public string? TrStatus { get; set; }
        public string? TrCreateBy { get; set; }
        public DateTime? TrCreateDate { get; set; }
        public string? TrEditBy { get; set; }
        public DateTime? TrEditDate { get; set; }
        public string? TrRemark { get; set; }
        public string? TrDocImage { get; set; }
        public int? TrSlot { get; set; }
        public int? TrActivity { get; set; }
    }
}
