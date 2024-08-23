using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("_sptTERMINALS")]
   public class Terminals
   {
      #region Public Constructors

       public Terminals()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public string Oid { get; set; }

       [Column("OID_TYPE")]
       public string OidType { get; set; }

       [Column("ID")]
       public int Id { get; set; }

       [Column("NAME")]
       public string Name { get; set; }

       [Column("STATE")]
       public int State { get; set; }

       [Column("TERMLANGUAGE")]
       public int TermLanguage { get; set; }


       #endregion Public Properties
   }
}
