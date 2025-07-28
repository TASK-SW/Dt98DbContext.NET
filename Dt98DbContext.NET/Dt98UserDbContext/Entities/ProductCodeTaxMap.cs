namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class ProductCodeTaxMap
    {
        public ProductCodeTaxMap()
        {
        }

        public int Id { get; set; }
        public int ExtCode { get; set; }
        public string VatOid { get; set; }
        public string ProductCodeName { get; set; }
    }
}