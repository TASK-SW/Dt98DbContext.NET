using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(Oid))]
   [Table("_sptGLOBALVALUES")]
   public class GlobalValues
   {
      #region Public Constructors

       public GlobalValues()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
       public string Oid { get; set; }

       [Column("DT_VALUE")]
       public string DtValue { get; set; }


       #endregion Public Properties
   }
}
