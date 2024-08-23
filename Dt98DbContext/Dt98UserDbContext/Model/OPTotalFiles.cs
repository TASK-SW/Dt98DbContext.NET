using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("OPTOTALFILES")]
   public class OpTotalFiles
   {
      #region Public Constructors

       public OpTotalFiles()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public string Oid { get; set; }

       [Column("STARTDATE")]
       public DateTime StartDate { get; set; }

       [Column("ACTUALGEN")]
       public int ActualGen { get; set; }

       [Column("DELIVGEN")]
       public int DelivGen { get; set; }

       [Column("DT_VERSION")]
       public int DtVersion { get; set; }


       #endregion Public Properties
   }
}
