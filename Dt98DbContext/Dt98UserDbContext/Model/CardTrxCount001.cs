using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("CARDTRXCOUNT001")]
   public class CardTrxCount001
   {
      #region Public Constructors

       public CardTrxCount001()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("PAN")]
       public string Pan { get; set; }

       [Column("COUNT")]
       public int Count { get; set; }

       [Column("EDITDATE")]
       public DateTime EditDate { get; set; }


       #endregion Public Properties
   }
}
