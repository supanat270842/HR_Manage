// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class DatumHistory
{
    public string headerQtdoc { get; set; }
    public string trTimeCheckin { get; set; }
    public int itemTime { get; set; }
    public string note { get; set; }
    public string docnumberImage { get; set; }
}

public class APIHistoryByDocModel
{
    public bool isSuccess { get; set; }
    public string isError { get; set; }
    public int isCode { get; set; }
    public List<DatumHistory> data { get; set; }
}
