using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("_sctUNITS")]
   public class Units
   {
      #region Public Constructors

       public Units()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("ID")]
       public int Id { get; set; }

       [Column("NAME")]
       public string Name { get; set; }

       [Column("SHORTCUT")]
       public string ShortCut { get; set; }

       [Column("DECIMALS")]
       public int Decimals { get; set; }


       #endregion Public Properties
   }
}
