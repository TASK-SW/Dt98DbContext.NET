using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("_sptPRODUCTCODEMAPS")]
   public class ProductCodeMaps
   {
      #region Public Constructors

       public ProductCodeMaps()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("ID")]
       public int Id { get; set; }

       [Key, Column(Order = 1)]
       //[Column("INTCODE")]
       public int IntCode { get; set; }

       [Column("EXTCODE")]
       public int ExtCode { get; set; }


       #endregion Public Properties
   }
}
