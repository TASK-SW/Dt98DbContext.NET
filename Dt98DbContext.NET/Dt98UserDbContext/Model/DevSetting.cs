using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(IdDevCfg), nameof(IdDevSet))]
   [Table("DEV_SETTING")]
   public class DevSetting
   {
      #region Public Constructors

       public DevSetting()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("ID_DEV_CFG")]
       public string IdDevCfg { get; set; }

       [Column("VAL_DEV_SET")]
       public string ValDevSet { get; set; }

       [Column("TYP_DEV_SET")]
       public int TypDevSet { get; set; }

       [Column("ID_DEV_SET")]
       public string IdDevSet { get; set; }


       #endregion Public Properties
   }
}
