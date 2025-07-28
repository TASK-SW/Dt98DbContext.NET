using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(OidParent), nameof(OidChild))]
    [Table("ARTICLEKITSET")]
    public class ArticleKitSet
    {
        #region Public Constructors

        public ArticleKitSet()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        //FK : Articles.Oid
        [Column("OID_PARENT")]
        public string OidParent { get; set; }

        //FK : Articles.Oid
        [Column("OID_CHILD")]
        public string OidChild { get; set; }

        [Column("COUNT")]
        public int Count { get; set; }

        #endregion Public Properties
    }
}