// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

namespace HR_Management.ViewModels;
public class ApproveBplusViewModel
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
    public List<ItemOtModel> itemOts { get; set; }
}

public class ItemOtModel
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
    
    public Boolean checkConfirm { get; set; }
}

