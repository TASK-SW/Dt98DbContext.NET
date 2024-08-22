namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("ArticleStock")]
    public class ArticleStock
    {
        #region Public Constructors

        public ArticleStock()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        [System.ComponentModel.DataAnnotations.Schema.Column("OIDArticle")]
        public string OidArticle { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("WorkstationId")]
        public int WorkstationId { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("CurrentQuantity")]
        public decimal CurrentQuantity { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("OpenQuantity")]
        public decimal OpenQuantity { get; set; }

        #endregion Public Properties
    }
}