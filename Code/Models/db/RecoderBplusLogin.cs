using System;
using System.Collections.Generic;

namespace HR_Management.Models.db;

public partial class RecoderBplusLogin
{
    public string RempId { get; set; }

    public string RempName { get; set; }

    public string RecoderEmpId { get; set; }

    public string RecodeEmpName { get; set; }

    public int? EmpKey { get; set; }
}
