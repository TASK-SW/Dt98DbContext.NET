using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class AlternativePrices
    {
        #region Public Constructors

        public AlternativePrices()
        { }

        #endregion Public Constructors

        #region Public Properties

        public string OidArticle { get; set; }

        public int PriceId { get; set; }

        public decimal SalesPrice { get; set; }

        #endregion Public Properties
    }
}