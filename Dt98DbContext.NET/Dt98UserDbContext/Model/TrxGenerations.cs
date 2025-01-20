using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(OidTrx), nameof(Generation))]
   [Table("TRXGENERATIONS")]
   public class TrxGenerations
   {
      #region Public Constructors

       public TrxGenerations()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID_TRX")]
       public string OidTrx { get; set; }

       [Column("GENERATION")]
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
