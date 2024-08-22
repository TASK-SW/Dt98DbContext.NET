namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("AlternativePrices")]
    public class AlternativePrices
    {
        #region Public Constructors

        public AlternativePrices()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        [System.ComponentModel.DataAnnotations.Schema.Column("OIDArticle")]
        public string OidArticle { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("PriceId")]
        public int PriceId { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("SalesPrice")]
        public decimal SalesPrice { get; set; }

        #endregion Public Properties
    }
}