using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    //===[===PrimaryKey(nameof(OidArticle), nameof(PriceId))]
    [Table("AlternativePrices")]
    public class AlternativePrices
    {
        #region Public Constructors

        public AlternativePrices()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        [Key]
        [Column("OIDArticle")]
        public string OidArticle { get; set; }

        [Key]
        [Column("PriceId")]
        public int PriceId { get; set; }

        [Column("SalesPrice")]
        public decimal SalesPrice { get; set; }

        #endregion Public Properties
    }
}