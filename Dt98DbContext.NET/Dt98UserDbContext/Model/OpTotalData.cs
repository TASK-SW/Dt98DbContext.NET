using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(Oid))]
   [Table("OPTOTALDATA")]
   public class OpTotalData
   {
      #region Public Constructors

       public OpTotalData()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
       public int Oid { get; set; }

       [Column("OID_HOST")]
       public string OidHost { get; set; }

       [Column("GENERATION")]
       public int Generation { get; set; }

       [Column("DT_TYPE")]
       public int DtType { get; set; }

       [Column("DT_TRANSACTION_ID")]
       public string DtTransactionId { get; set; }

       [Column("DT_PRODUCT_ID")]
       public string DtProductId { get; set; }

       [Column("DT_AMOUNT")]
       public decimal DtAmount { get; set; }

       [Column("DT_QUANTITY")]
       public decimal DtQuantity { get; set; }

       [Column("UNITCODE")]
       public string UnitCode { get; set; }

       [Column("DT_COUNT")]
       public int DtCount { get; set; }


       #endregion Public Properties
   }
}
