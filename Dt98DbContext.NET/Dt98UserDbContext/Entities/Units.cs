using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(Id))]
   [Table("_sctUNITS")]
   public class Units
   {
      #region Public Constructors

       public Units()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("ID")]
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
