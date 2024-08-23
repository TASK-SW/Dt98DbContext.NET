using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("BLACKLIST_LOCAL_0001S")]
   public class BlackListLocal0001S
   {
      #region Public Constructors

       public BlackListLocal0001S()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
       public int Oid { get; set; }

       [Column("PAN")]
       public string Pan { get; set; }

       [Column("WITHDRAW")]
       public int WithDraw { get; set; }


       #endregion Public Properties
   }
}
