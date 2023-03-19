namespace ForJawalySMSHelper.Models
{
    public class Message2
    {
        public int account_id { get; set; }
        public string job_id { get; set; }
        public string text { get; set; }
        public int sender_id { get; set; }
        public string sender_name { get; set; }
        public string encoding { get; set; }
        public int length { get; set; }
        public int per_message { get; set; }
        public int remaining { get; set; }
        public int messages { get; set; }
        public object send_at { get; set; }
        public object send_at_zone { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime created_at { get; set; }
        public int id { get; set; }
        public Account account { get; set; }
    }
}
