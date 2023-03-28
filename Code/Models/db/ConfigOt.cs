using System;
using System.Collections.Generic;

namespace HR_Management.Models.db;

public partial class ConfigOt
{
    public int ConfigOtid { get; set; }

    public string ConfigOttype { get; set; }

    public string ConfigOttime { get; set; }

    public string ConfigOttimeType { get; set; }

    public string ConfigOttimeActive { get; set; }
}
