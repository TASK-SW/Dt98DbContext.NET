using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    //===[===PrimaryKey(nameof(Id))]
   [Table("_sptTOTALHANDLER")]
   public class TotalHandler
   {
      #region Public Constructors

       public TotalHandler()
      {
      }

        #endregion Public Constructors

        #region Public Properties

        [Key]
        [Column("ID")]
       public string Id { get; set; }

       [Column("CLSID")]
       public string ClsId { get; set; }


       #endregion Public Properties
   }
}
