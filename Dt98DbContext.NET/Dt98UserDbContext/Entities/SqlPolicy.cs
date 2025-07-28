namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class SqlPolicy
    {
        public SqlPolicy()
        {
        }

        public string Oid { get; set; }
        public string PolType { get; set; }
        public string Server { get; set; }
        public string User { get; set; }
        public string Pwd { get; set; }
        public string DataBase { get; set; }
        public string Directory { get; set; }
        public int Option { get; set; }
        public string AddData { get; set; }
    }
}