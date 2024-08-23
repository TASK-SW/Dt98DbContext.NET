using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("CARDDLYTOTAL046")]
   public class CardDlyTotal046
   {
      #region Public Constructors

       public CardDlyTotal046()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("PAN")]
       public string Pan { get; set; }

       [Column("AMOUNT")]
       public decimal Amount { get; set; }

       [Column("OUTDOORAMOUNT")]
       public decimal OutdoorAmount { get; set; }

       [Column("EDITDATE")]
       public DateTime EditDate { get; set; }

       [Column("DOP_INDOOR_AMT")]
       public decimal DopIndoorAmt { get; set; }

       [Column("DOP_INDOOR_CNT")]
       public int DopIndoorCnt { get; set; }

       [Column("DOP_OUTDOOR_AMT")]
       public decimal DopOutdoorAmt { get; set; }

       [Column("DOP_OUTDOOR_CNT")]
       public int DopOutdoorCnt { get; set; }


       #endregion Public Properties
   }
}
