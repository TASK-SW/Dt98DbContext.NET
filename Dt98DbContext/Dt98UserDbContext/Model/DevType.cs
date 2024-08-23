using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("DEV_TYPE")]
   public class DevType
   {
      #region Public Constructors

       public DevType()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("ID_DEV_TYP")]
       public string IdDevTyp { get; set; }

       [Key, Column(Order = 1)]
       //[Column("ID_DEV_CLS")]
       public string IdDevCls { get; set; }

       [Column("NM_DEV_TYP")]
       public string NmdevTyp { get; set; }

       [Column("CLSID_DEV_TYP")]
       public string ClsIdDevTyp { get; set; }


       #endregion Public Properties
   }
}
