// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class ListHistoryViewModel
{
    public int trSlot { get; set; }
    public int trAutoId { get; set; }
    public TimeSpan? trTimeCheckinAll { get; set; }
    public string trCreateBy { get; set; }
    public string reMark { get; set; }
    public int trActivity { get; set; }
    public string headerQtdoc { get; set; }
    public string trTimeCheckin { get; set; }
    public int itemTime { get; set; }
    // public string headerQtDoc { get; set; }
    public string headerQTDateStAffect { get; set; }
    public string headerQTTimeStAffect { get; set; }
    public string headerQTDateEnAffect { get; set; }
    public string headerQTTimeEnAffect { get; set; }
    public string headerQTNameYard { get; set; }
    public string headerQTLeaderName { get; set; }
    public string headerQTSumPersons { get; set; }
    public string note { get; set; }
    public string _note { get; set; }
    public string image { get; set; }
    public int imageAutoId { get; set; }
    public string docnumberImage { get; set; }

    public string stfStreamId { get; set; }
    public string headerQTDoc { get; set; }
    public int count { get; set; }

}