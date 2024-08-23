using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("DEV_SETTING")]
   public class DevSetting
   {
      #region Public Constructors

       public DevSetting()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("ID_DEV_CFG")]
       public string IdDevCfg { get; set; }

       [Column("VAL_DEV_SET")]
       public string ValDevSet { get; set; }

       [Column("TYP_DEV_SET")]
       public int TypDevSet { get; set; }

       [Key, Column(Order = 1)]
       //[Column("ID_DEV_SET")]
       public string IdDevSet { get; set; }


       #endregion Public Properties
   }
}
