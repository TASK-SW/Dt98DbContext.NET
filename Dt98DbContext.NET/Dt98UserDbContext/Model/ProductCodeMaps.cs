using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(Id), nameof(IntCode))]
   [Table("_sptPRODUCTCODEMAPS")]
   public class ProductCodeMaps
   {
      #region Public Constructors

       public ProductCodeMaps()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("ID")]
       public int Id { get; set; }

       [Column("INTCODE")]
       public int IntCode { get; set; }

       [Column("EXTCODE")]
       public int ExtCode { get; set; }


       #endregion Public Properties
   }
}
