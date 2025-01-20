using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(Oid))]
   [Table("_sptOPTOTAL_BASEMATRIX")]
   public class OpTotalBaseMatrix
   {
      #region Public Constructors

       public OpTotalBaseMatrix()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
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
