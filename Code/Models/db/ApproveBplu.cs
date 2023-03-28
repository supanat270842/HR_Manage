using System;
using System.Collections.Generic;

namespace HR_Management.Models.db;

public partial class ApproveBplu
{
    public int ApbautoId { get; set; }

    public int? ApbtypeId { get; set; }

    public string MempId { get; set; }

    public string MempName { get; set; }

    public string ApbfacId { get; set; }

    public string MdepId { get; set; }

    public string MdepName { get; set; }

    public int? ApbsequenceApprove { get; set; }

    public string Apbstatus { get; set; }

    public DateTime? ApbeditDate { get; set; }

    public string ApbeditBy { get; set; }

    public string Apbremark { get; set; }
}
