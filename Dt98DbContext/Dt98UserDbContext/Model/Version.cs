using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("__VERSION")]
   public class Version
   {
      #region Public Constructors

       public Version()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("DB_VERSION")]
       public string DbVersion { get; set; }


       #endregion Public Properties
   }
}
