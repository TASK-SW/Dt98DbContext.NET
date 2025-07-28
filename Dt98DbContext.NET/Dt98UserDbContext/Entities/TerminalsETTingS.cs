using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    //===[===PrimaryKey(nameof(Oid))]
   [Table("_sptTERMINALSETTINGS")]
   public class TerminalSettings
   {
      #region Public Constructors

       public TerminalSettings()
      {
      }

        #endregion Public Constructors

        #region Public Properties

        [Key]
        [Column("OID")]
       public string Oid { get; set; }

        //FK : TerminalComponents.Oid
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
