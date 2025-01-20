using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(Oid))]
   [Table("TankNetz")]
   public class TankNetz
   {
      #region Public Constructors

       public TankNetz()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
       public string Oid { get; set; }

       [Column("DateTime")]
       public DateTime DateTime { get; set; }

       [Column("JournalId")]
       public int JournalId { get; set; }

       [Column("StationId")]
       public int StationId { get; set; }

       [Column("TerminalId")]
       public int TerminalId { get; set; }

       [Column("FirstCard")]
       public string FirstCard { get; set; }

       [Column("SecondCard")]
       public int SecondCard { get; set; }

       [Column("Mileage")]
       public int Mileage { get; set; }

       [Column("AddInfo")]
       public int AddInfo { get; set; }

       [Column("ArticleId")]
       public int ArticleId { get; set; }

       [Column("FPId")]
       public int FpId { get; set; }

       [Column("ProductType")]
       public int ProductType { get; set; }

       [Column("Quantity")]
       public decimal Quantity { get; set; }

       [Column("UnitPrice")]
       public decimal UnitPrice { get; set; }

       [Column("Amount")]
       public decimal Amount { get; set; }

       [Column("Nummerator")]
       public int Nummerator { get; set; }

       [Column("PIN")]
       public int Pin { get; set; }

       [Column("ArticleName")]
       public string ArticleName { get; set; }

       [Column("TraceNo")]
       public string TraceNo { get; set; }


       #endregion Public Properties
   }
}
