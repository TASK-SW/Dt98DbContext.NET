using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("_sptOPTOTAL_BASEMATRIX")]
   public class OpTotalBaseMatrix
   {
      #region Public Constructors

       public OpTotalBaseMatrix()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public int Oid { get; set; }

       [Column("DT_PRODUCT_ID")]
       public string DtProductId { get; set; }

       [Column("DT_TRANSACTION_ID")]
       public string DtTransactionId { get; set; }

       [Column("DT_TYPE")]
       public int DtType { get; set; }


       #endregion Public Properties
   }
}
