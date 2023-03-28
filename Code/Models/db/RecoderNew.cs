using System;
using System.Collections.Generic;

namespace HR_Management.Models.db;

public partial class RecoderNew
{
    public int RnautoId { get; set; }

    public string Rnfactory { get; set; }

    public string RecoderName { get; set; }

    public string RnuserName { get; set; }

    public string Rnpassword { get; set; }

    public string Rnstatus { get; set; }

    public DateTime? RncreateDate { get; set; }

    public string RncreateBy { get; set; }

    public DateTime? RneditDate { get; set; }

    public string RneditBy { get; set; }
}
