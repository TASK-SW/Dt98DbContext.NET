namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class DatacomOnlineHosts
    {
        public DatacomOnlineHosts()
        {
        }

        public int HostId { get; set; }
        public int RecordState { get; set; }
        public string ApplicationId { get; set; }
        public string HostAddressIsdnB { get; set; }
        public string HostAddressIP { get; set; }
        public int MessageTimeout { get; set; }
        public int RetryCountAuthorization { get; set; }
        public int RetryCountCancellation { get; set; }
        public int MacKeyId { get; set; }
        public string MacKey { get; set; }
        public int EncKeyId { get; set; }
        public string EncKey { get; set; }
        public int? OlisVersion { get; set; }
    }
}