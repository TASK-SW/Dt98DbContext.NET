namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class CardTypes
    {
        public CardTypes()
        {
        }

        public string Oid { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string IId { get; set; }
        public string ClsId { get; set; }
        public string IIdLayout { get; set; }
        public string ClsIdLayout { get; set; }
        public string OidCardBaseType { get; set; }
        public string IIdManualCardDlg { get; set; }
        public string ClsIdManualCardDlg { get; set; }
    }
}