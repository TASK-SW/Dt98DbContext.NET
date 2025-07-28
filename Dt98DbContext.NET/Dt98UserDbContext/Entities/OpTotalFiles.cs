using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    //===[===PrimaryKey(nameof(Oid))]
   [Table("OPTOTALFILES")]
   public class OpTotalFiles
   {
      #region Public Constructors

       public OpTotalFiles()
      {
      }

        #endregion Public Constructors

        #region Public Properties

        [Key]
        [Column("OID")]
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
