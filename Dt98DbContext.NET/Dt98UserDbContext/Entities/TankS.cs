using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(Oid))]
   [Table("_sptTANKS")]
   public class TankS
   {
      #region Public Constructors

       public TankS()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
       public string Oid { get; set; }

       [Column("OID_TYPE")]
       public string OidType { get; set; }

       [Column("OID_ARTICLE")]
       public string OidArticle { get; set; }

       [Column("OID_TANKLEVELTAB")]
       public string OidTankLevelTab { get; set; }

       [Column("ID")]
       public int Id { get; set; }

       [Column("VOLUME")]
       public decimal Volume { get; set; }

       [Column("LENGTH")]
       public decimal Length { get; set; }

       [Column("HEIGHT")]
       public decimal Height { get; set; }

       [Column("WIDTH")]
       public decimal Width { get; set; }


       #endregion Public Properties
   }
}
