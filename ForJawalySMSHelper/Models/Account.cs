namespace ForJawalySMSHelper.Models
{
    public class Account
    {
        public int id { get; set; }
        public int account_id { get; set; }
        public int user_id { get; set; }
        public int currency_id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string name_hash { get; set; }
        public string username_hash { get; set; }
        public string email_hash { get; set; }
        public string mobile_hash { get; set; }
        public object main_account_id { get; set; }
        public int status { get; set; }
        public int is_marketer { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string queue_number { get; set; }
    }
}
