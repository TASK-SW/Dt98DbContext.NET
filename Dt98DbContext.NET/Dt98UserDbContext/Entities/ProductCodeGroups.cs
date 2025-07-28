using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    //===[===PrimaryKey(nameof(Oid))]
   [Table("_sptPRODUCTCODEGROUPS")]
   public class ProductCodeGroups
   {
      #region Public Constructors

       public ProductCodeGroups()
      {
      }

        #endregion Public Constructors

        #region Public Properties

        [Key]
        [Column("OID")]
       public string Oid { get; set; }

       [Column("ID")]
       public int Id { get; set; }

       [Column("DESCRIPTION")]
       public string Description { get; set; }

       [Column("FIXED_VAT")]
       public int FixedVat { get; set; }


       #endregion Public Properties
   }
}
