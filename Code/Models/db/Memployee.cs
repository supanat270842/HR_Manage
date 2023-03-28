using System;
using System.Collections.Generic;

namespace HR_Management.Models.db;

public partial class Memployee
{
    public int MempAutoId { get; set; }

    public string MdepId { get; set; }

    public string MempId { get; set; }

    public string MempName { get; set; }

    public string MempStatus { get; set; }

    public DateTime? MempEditDate { get; set; }

    public string MempRemark { get; set; }

    public int? EmpKey { get; set; }

    public string MadminFac { get; set; }
}
