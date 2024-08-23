using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("_sptGLOBALVALUES")]
   public class GlobalValues
   {
      #region Public Constructors

       public GlobalValues()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public string Oid { get; set; }

       [Column("DT_VALUE")]
       public string DtValue { get; set; }


       #endregion Public Properties
   }
}
