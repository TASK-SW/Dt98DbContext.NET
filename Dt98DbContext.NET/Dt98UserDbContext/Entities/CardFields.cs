namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class CardFields
    {
        public CardFields()
        {
        }

        public string Oid { get; set; }
        public string OidType { get; set; }
        public int FieldId { get; set; }
        public int? Position { get; set; }
        public int? Length { get; set; }
        public int? CheckOption { get; set; }
        public int? MinSize { get; set; }
        public int? MaxSize { get; set; }
        public int? TextId { get; set; }
    }
}