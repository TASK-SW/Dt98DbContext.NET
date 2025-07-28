using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    //===[===PrimaryKey(nameof(Oid))]
   [Table("_sptPUMPS")]
   public class Pumps
   {
      #region Public Constructors

       public Pumps()
      {
      }

        #endregion Public Constructors

        #region Public Properties

        [Key]
        [Column("OID")]
       public string Oid { get; set; }

        //FK : PumpTypes.Oid
        [Column("OID_TYPE")]
       public string OidType { get; set; }

       [Column("ID")]
       public int Id { get; set; }


       #endregion Public Properties
   }
}
