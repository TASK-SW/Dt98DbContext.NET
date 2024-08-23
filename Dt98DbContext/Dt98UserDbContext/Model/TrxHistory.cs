using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("TRXHISTORY")]
   public class TrxHistory
   {
      #region Public Constructors

       public TrxHistory()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("APPLICATION")]
       public string Application { get; set; }

       [Column("GENERATION")]
       public int Generation { get; set; }

       [Column("DATESTART")]
       public DateTime DateStart { get; set; }

       [Column("DATEEND")]
       public DateTime DateEnd { get; set; }

       [Column("DATEDELIVERY")]
       public DateTime DateDelivery { get; set; }

       [Column("DATECLEARED")]
       public DateTime DateCLEARed { get; set; }

       [Column("TOTAL")]
       public decimal Total { get; set; }

       [Column("TRANSCOUNT")]
       public int TransCount { get; set; }


       #endregion Public Properties
   }
}
