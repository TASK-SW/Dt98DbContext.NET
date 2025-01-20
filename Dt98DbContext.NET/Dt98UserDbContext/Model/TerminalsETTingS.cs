using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(Oid))]
   [Table("_sptTERMINALSETTINGS")]
   public class TerminalSettings
   {
      #region Public Constructors

       public TerminalSettings()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
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
