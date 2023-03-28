// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class DatumListOT
    {
        public int headerQTID { get; set; }
        public string headerQTDoc { get; set; }
        public string headerQTRevise { get; set; }
        public string headerQTPlant { get; set; }
        public string headerQTYard { get; set; }
        public string headerQTDep { get; set; }
        public string headerQTDateStAffect { get; set; }
        public string headerQTTimeStAffect { get; set; }
        public string headerQTDateEnAffect { get; set; }
        public string headerQTTimeEnAffect { get; set; }
        public string headerQTHRAffect { get; set; }
        public string headerQTSumPersons { get; set; }
        public string headerQTSumOT { get; set; }
        public string headerQTDetailOT { get; set; }
        public string headerQTLeaderID { get; set; }
        public string headerQTLeaderName { get; set; }
        public string headerQTTypeApprove { get; set; }
        public string headerQTStatusApprove { get; set; }
        public string headerQTRemarkApprove { get; set; }
        public string headerQTStatus { get; set; }
        public string headerQTCreateDate { get; set; }
        public string headerQTCreateBy { get; set; }
        public string headerQTEditDate { get; set; }
        public string headerQTEditBy { get; set; }
        public string headerQTRemark { get; set; }
        public string headerQTNameYard { get; set; }
        public object headerQTStatusTime { get; set; }
        public object headerQTReviseHR { get; set; }
        public object headerConfirm { get; set; }
        public object headerTypeOT { get; set; }
        public string headerQTCondition { get; set; }
        public object stT_KEY { get; set; }
        public List<ItemOt> itemOts { get; set; }
    }

    public class ItemOt
    {
        public int itemQTID { get; set; }
        public string itemQTDoc { get; set; }
        public string itemQTRevise { get; set; }
        public string itemQTEmpId { get; set; }
        public string itemQTEmpName { get; set; }
        public string itemQTTimeStAffect { get; set; }
        public string itemQTTimeEnAffect { get; set; }
        public string itemQTTotalTime { get; set; }
        public string itemQTStatus { get; set; }
        public string itemQTCreateDate { get; set; }
        public string itemQTCreateBy { get; set; }
        public string itemQTEditDate { get; set; }
        public string itemQTEditBy { get; set; }
        public string itemQTRemark { get; set; }
        public object bPlusDocNo { get; set; }
        public string itemQTCondition { get; set; }
        public object itemRPAStatus { get; set; }
        public object approveProcess { get; set; }
    }

    public class APIListOTModel
    {
        public bool isSuccess { get; set; }
        public string isError { get; set; }
        public int isCode { get; set; }
        public List<DatumListOT> data { get; set; }
    }

