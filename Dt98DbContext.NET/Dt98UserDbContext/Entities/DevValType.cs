using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(IdValType))]
   [Table("DEV_VALTYPE")]
   public class DevValType
   {
      #region Public Constructors

       public DevValType()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("ID_VAL_TYPE")]
       public int IdValType { get; set; }

       [Column("NM_VAL_TYPE")]
       public string NmValType { get; set; }


       #endregion Public Properties
   }
}
