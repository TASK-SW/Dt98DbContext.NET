using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("ARTICLEGROUPS")]
   public class ArticleGroups
   {
      #region Public Constructors

       public ArticleGroups()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public string Oid { get; set; }

       [Column("ID")]
       public string Id { get; set; }

       [Column("NAME")]
       public string Name { get; set; }


       #endregion Public Properties
   }
}
