using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("_persNOZZLES")]
   public class persNozzles
   {
      #region Public Constructors

       public persNozzles()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public string Oid { get; set; }

       [Column("VOLUME")]
       public decimal Volume { get; set; }

       [Column("AMOUNT")]
       public decimal Amount { get; set; }


       #endregion Public Properties
   }
}
