using System;
using System.Collections.Generic;

namespace HR_Management.Models.dbCPS
{
    public partial class ScanFile
    {
        public int ScanFileAutoId { get; set; }
        public string? ScanFileDoc { get; set; }
        public string? ScanFileRevise { get; set; }
        public string? ScanFileYear { get; set; }
        public string? ScanFileMonth { get; set; }
        public string? ScanFileStatus { get; set; }
        public string? ScanFilePlant { get; set; }
        public DateTime? ScanFileDate { get; set; }
    }
}
