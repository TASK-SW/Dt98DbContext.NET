using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("_sctBLACKLISTTYPES")]
   public class BlackListTypes
   {
      #region Public Constructors

       public BlackListTypes()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public string Oid { get; set; }

       [Column("ID")]
       public int Id { get; set; }

       [Column("NAME")]
       public string Name { get; set; }

       [Column("IID")]
       public string IId { get; set; }

       [Column("CLSID")]
       public string ClsId { get; set; }


       #endregion Public Properties
   }
}
