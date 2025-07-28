using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    //===[===PrimaryKey(nameof(Oid))]
   [Table("_persNOZZLES")]
   public class persNozzles
   {
      #region Public Constructors

       public persNozzles()
      {
      }

        #endregion Public Constructors

        #region Public Properties

        [Key]
        [Column("OID")]
       public string Oid { get; set; }

       [Column("VOLUME")]
       public decimal Volume { get; set; }

       [Column("AMOUNT")]
       public decimal Amount { get; set; }


       #endregion Public Properties
   }
}
