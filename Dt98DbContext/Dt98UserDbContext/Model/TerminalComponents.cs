using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("_sptTERMINALCOMPONENTS")]
   public class TerminalComponents
   {
      #region Public Constructors

       public TerminalComponents()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public string Oid { get; set; }

       [Column("OID_TERMINAL")]
       public string OidTerminal { get; set; }

       [Column("ID")]
       public int Id { get; set; }

       [Column("IID")]
       public string IId { get; set; }

       [Column("CLSID")]
       public string ClsId { get; set; }


       #endregion Public Properties
   }
}
