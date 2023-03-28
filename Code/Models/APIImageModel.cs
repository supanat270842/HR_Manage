// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class DatumImage
    {
        public int stfAutoId { get; set; }
        public string stfProjectType { get; set; }
        public string stfProjectId { get; set; }
        public string stfFileId { get; set; }
        public string stfStreamId { get; set; }
        public DateTime stfCreateDate { get; set; }
        public string stfRemark { get; set; }
        public int stfItem { get; set; }
        public string stfStatus { get; set; }
    }

    public class APIImageModel
    {
        public bool isSuccess { get; set; }
        public string isError { get; set; }
        public string isCode { get; set; }
        public List<DatumImage> data { get; set; }
    }