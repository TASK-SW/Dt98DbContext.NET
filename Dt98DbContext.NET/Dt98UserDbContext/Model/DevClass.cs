using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(IdDevCls))]
   [Table("DEV_CLASS")]
   public class DevClass
   {
      #region Public Constructors

       public DevClass()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("ID_DEV_CLS")]
       public string IdDevCls { get; set; }

       [Column("NM_DEV_CLS")]
       public string NmdevCls { get; set; }


       #endregion Public Properties
   }
}
