using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    //===[===PrimaryKey(nameof(Oid))]
   [Table("_sptTRXFILES")]
   public class sptTrxFiles
   {
      #region Public Constructors

       public sptTrxFiles()
      {
      }

        #endregion Public Constructors

        #region Public Properties

        [Key]
        [Column("OID")]
       public string Oid { get; set; }

        //FK : TrxFileTypes.Oid
        [Column("OID_TYPE")]
       public string OidType { get; set; }

       [Column("ID")]
       public int Id { get; set; }

       [Column("RESETDATE")]
       public DateTime ResetDate { get; set; }


       #endregion Public Properties
   }
}
