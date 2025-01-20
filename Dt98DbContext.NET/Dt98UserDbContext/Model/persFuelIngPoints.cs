using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(Oid))]
   [Table("_persFUELINGPOINTS")]
   public class persFuelIngPoints
   {
      #region Public Constructors

       public persFuelIngPoints()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
       public string Oid { get; set; }

       [Column("OID_FUELSALE")]
       public string OidFuelSale { get; set; }

       [Column("CONTROLSTATE")]
       public int ControlState { get; set; }

       [Column("LASTERROR")]
       public int LastError { get; set; }

       [Column("ERRORCOUNT")]
       public int ErrorCount { get; set; }

       [Column("CURRENTNOZZLE")]
       public int CurrentNozzle { get; set; }

       [Column("LT_NUMMERATEUR")]
       public int LtNummeRateUr { get; set; }

       [Column("LT_VOLUME")]
       public int LtVolume { get; set; }

       [Column("LT_AMOUNT")]
       public int LtAmount { get; set; }

       [Column("LT_NOZZLE")]
       public int LtNozzle { get; set; }

       [Column("PS_STATE")]
       public int PsState { get; set; }

       [Column("PS_ERROR")]
       public int PsError { get; set; }

       [Column("PS_COUNTER1")]
       public int PsCountEr1 { get; set; }

       [Column("PS_COUNTER2")]
       public int PsCountEr2 { get; set; }

       [Column("PS_COUNTER3")]
       public int PsCountEr3 { get; set; }

       [Column("PS_COUNTER4")]
       public int PsCountEr4 { get; set; }

       [Column("PS_NUMMERATEUR")]
       public int PsNummeRateUr { get; set; }


       #endregion Public Properties
   }
}
