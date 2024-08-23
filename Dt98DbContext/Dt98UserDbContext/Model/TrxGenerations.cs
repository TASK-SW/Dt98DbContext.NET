using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("TRXGENERATIONS")]
   public class TrxGenerations
   {
      #region Public Constructors

       public TrxGenerations()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID_TRX")]
       public string OidTrx { get; set; }

       [Key, Column(Order = 1)]
       //[Column("GENERATION")]
       public int Generation { get; set; }

       [Column("STARTDATE")]
       public DateTime StartDate { get; set; }

       [Column("ENDDATE")]
       public DateTime EndDate { get; set; }

       [Column("DELIVERYDATE")]
       public DateTime DeliveryDate { get; set; }


       #endregion Public Properties
   }
}
