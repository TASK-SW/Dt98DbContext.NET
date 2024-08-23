using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("DEV_VALTYPE")]
   public class DevValType
   {
      #region Public Constructors

       public DevValType()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("ID_VAL_TYPE")]
       public int IdValType { get; set; }

       [Column("NM_VAL_TYPE")]
       public string NmValType { get; set; }


       #endregion Public Properties
   }
}
