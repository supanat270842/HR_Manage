using System;
using System.Collections.Generic;

namespace HR_Management.Models.db;

public partial class Recoder
{
    public int RautoId { get; set; }

    public string RempId { get; set; }

    public string RempName { get; set; }

    public string RecoderEmpId { get; set; }

    public string RecodeEmpName { get; set; }

    public string RdepId { get; set; }

    public string RdepName { get; set; }

    public string Rstatus { get; set; }

    public DateTime? ReditDate { get; set; }

    public string ReditBy { get; set; }
}
