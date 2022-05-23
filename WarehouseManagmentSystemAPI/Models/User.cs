namespace WarehouseManagmentSystemAPI.Models
{
    class User
    {
        public string id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string creditCardNumber { get; set; }
        public string expDate { get; set; }
        public int cvv { get; set; }
        public string address { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string profilePictureUrl { get; set; }
        public DateTime timeCreated { get; set; }
        public DateTime timeNow { get; set; }
    }
}