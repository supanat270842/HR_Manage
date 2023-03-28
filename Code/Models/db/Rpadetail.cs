using System;
using System.Collections.Generic;

namespace HR_Management.Models.db;

public partial class Rpadetail
{
    public string เลขทเอกสาร { get; set; }

    public string Ot { get; set; }

    public string ประเภทOt { get; set; }

    public string รหสพนกงาน { get; set; }

    public string ชอ { get; set; }

    public DateTime? วนททำOt { get; set; }

    public TimeSpan? เวลาเรมตน { get; set; }

    public TimeSpan? เวลาสนสด { get; set; }

    public string เวลารวม { get; set; }

    public string หมายเหต { get; set; }
}
