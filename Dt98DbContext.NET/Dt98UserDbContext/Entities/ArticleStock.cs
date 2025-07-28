using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class ArticleStock
    {
        #region Public Constructors

        public ArticleStock()
        { }

        #endregion Public Constructors

        #region Public Properties

        public string OidArticle { get; set; }

        public int WorkstationId { get; set; }

        public decimal CurrentQuantity { get; set; }

        public decimal OpenQuantity { get; set; }

        #endregion Public Properties
    }
}