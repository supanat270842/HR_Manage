// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class DatumGetFac_Dep
    {
        public int factoryId { get; set; }
        public string factoryName { get; set; }
        public string factoryDepartments { get; set; }
        public string factoryCreateDate { get; set; }
        public string factoryCreateUser { get; set; }
        public string factoryEditUser { get; set; }
        public string factoryEditDate { get; set; }
        public string factoryStatus { get; set; }
        public string factoryDepartmentsId { get; set; }
    }

    public class APIFacDepModel
    {
        public bool isSuccess { get; set; }
        public string isError { get; set; }
        public int isCode { get; set; }
        public List<DatumGetFac_Dep> data { get; set; }
    }
