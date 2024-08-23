using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("_sptTERMINALSETTINGS")]
   public class TerminalSettings
   {
      #region Public Constructors

       public TerminalSettings()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public string Oid { get; set; }

       [Column("OID_TERMINALCOMPONENT")]
       public string OidTerminalComponent { get; set; }

       [Column("ID")]
       public string Id { get; set; }

       [Column("VALUE")]
       public string Value { get; set; }

       [Column("TYPE")]
       public int Type { get; set; }


       #endregion Public Properties
   }
}
