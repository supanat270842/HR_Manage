// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class DatumGetPlant
    {
        public int plantautoid { get; set; }
        public string plantid { get; set; }
        public string plantname { get; set; }
        public string plantstatus { get; set; }
        public string plantsap { get; set; }
    }

    public class APIPlantModel
    {
        public bool isSuccess { get; set; }
        public string isError { get; set; }
        public int isCode { get; set; }
        public List<DatumGetPlant> data { get; set; }
    }