using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("BLACKLIST001")]
   public class BlackList001
   {
      #region Public Constructors

       public BlackList001()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public string Oid { get; set; }

       [Column("OID_BLACKLIST")]
       public string OidBlackList { get; set; }

       [Column("LOWERPAN")]
       public string LowerPan { get; set; }

       [Column("UPPERPAN")]
       public string UpperPan { get; set; }

       [Column("WITHDRAW")]
       public int WithDraw { get; set; }

       [Column("MUTATOR")]
       public int Mutator { get; set; }


       #endregion Public Properties
   }
}
