using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(Pan))]
   [Table("CARDDLYTOTAL158")]
   public class CardDlyTotal158
   {
      #region Public Constructors

       public CardDlyTotal158()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("PAN")]
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
