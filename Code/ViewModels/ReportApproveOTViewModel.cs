// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

namespace HR_Management.ViewModels;
public class ReportApproveOTViewModel
{
    public int HeaderQtid { get; set; }
    public string? HeaderQtdoc { get; set; }
    public string? HeaderQtplant { get; set; }
    public DateTime? HeaderQtdateStAffect { get; set; }
    public TimeSpan? HeaderQttimeStAffect { get; set; }
    public DateTime? HeaderQtdateEnAffect { get; set; }
    public TimeSpan? HeaderQttimeEnAffect { get; set; }
    public string? HeaderQtstatusApprove { get; set; }
    public string? HeaderQtstatus { get; set; }
    public DateTime? HeaderQteditDate { get; set; }
    public string? HeaderQteditBy { get; set; }
    public string? HeaderConfirm { get; set; }
    public string? HeaderTypeOt { get; set; }
    public bool? HeaderQtcondition { get; set; }
    public string HeaderQtSum { get; set; }
    public string OttName { get; set; }
    public string RMRemark { get; set; }
    public List<ItemApproveOtModel> itemOts { get; set; }
}

public class ItemApproveOtModel
{
    public int HeaderQtid { get; set; }
    public string? HeaderQtdoc { get; set; }
    public string? HeaderQtplant { get; set; }
    public DateTime? HeaderQtdateStAffect { get; set; }
    public TimeSpan? HeaderQttimeStAffect { get; set; }
    public DateTime? HeaderQtdateEnAffect { get; set; }
    public TimeSpan? HeaderQttimeEnAffect { get; set; }
    public string? HeaderQtstatusApprove { get; set; }
    public string? HeaderQtstatus { get; set; }
    public DateTime? HeaderQteditDate { get; set; }
    public string? HeaderQteditBy { get; set; }
    public string? HeaderConfirm { get; set; }
    public string? HeaderTypeOt { get; set; }
    public bool? HeaderQtcondition { get; set; }
    public string HeaderQtSum { get; set; }
    public string OttName { get; set; }
    public string RMRemark { get; set; }
    
    public Boolean checkConfirm { get; set; }
}

