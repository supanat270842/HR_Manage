using System;
using System.Collections.Generic;

namespace HR_Management.Models.db;

public partial class ApproveBplusLogin
{
    public string ApbtypeId { get; set; }

    public string MempId { get; set; }

    public string MempName { get; set; }

    public string ApbfacId { get; set; }

    public string MdepId { get; set; }

    public string MdepName { get; set; }

    public int? ApbsequenceApprove { get; set; }

    public int? EmpKey { get; set; }
}
