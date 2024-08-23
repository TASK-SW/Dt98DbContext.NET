using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("VMA_TempFuelings")]
   public class VmaTempFuelings
   {
      #region Public Constructors

       public VmaTempFuelings()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public string Oid { get; set; }

       [Column("EntryTime")]
       public DateTime EntryTime { get; set; }

       [Column("FuelingTime")]
       public DateTime FuelingTime { get; set; }

       [Column("ProductId")]
       public int ProductId { get; set; }

       [Column("FuelPointId")]
       public int FuelPointId { get; set; }

       [Column("NozzleId")]
       public int NozzleId { get; set; }

       [Column("ProcessingState")]
       public int ProcessingState { get; set; }

       [Column("Amount")]
       public decimal Amount { get; set; }

       [Column("Volume")]
       public decimal Volume { get; set; }

       [Column("TankConfig")]
       public string TankConfig { get; set; }


       #endregion Public Properties
   }
}
