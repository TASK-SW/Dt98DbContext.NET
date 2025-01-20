using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(IdDevCfg))]
   [Table("DEV_CONFIG")]
   public class DevConfig
   {
      #region Public Constructors

       public DevConfig()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("ID_DEV_CFG")]
       public string IdDevCfg { get; set; }

       [Column("ID_DEV_TYP")]
       public string IdDevTyp { get; set; }

       [Column("ID_DEV_CLS")]
       public string IdDevCls { get; set; }

       [Column("ID_DEV_PAR")]
       public string IdDevPar { get; set; }


       #endregion Public Properties
   }
}
