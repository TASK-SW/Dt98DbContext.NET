using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    //===[===PrimaryKey(nameof(Oid))]
    [Table("ARTICLEGROUPS")]
    public class ArticleGroups
    {
        #region Public Constructors

        public ArticleGroups()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        [Key]
        [Column("OID")]
        public string Oid { get; set; }

        [Column("ID")]
        public string Id { get; set; }

        [Column("NAME")]
        public string Name { get; set; }

        #endregion Public Properties
    }
}