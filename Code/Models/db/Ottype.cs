using System;
using System.Collections.Generic;

namespace HR_Management.Models.db;

public partial class Ottype
{
    public int OttAutoId { get; set; }

    public string OttName { get; set; }

    public string OttStatus { get; set; }

    public string OttCreateBy { get; set; }

    public DateTime? OttCreateDate { get; set; }

    public string OttEditBy { get; set; }

    public DateTime? OttEditDate { get; set; }
}
