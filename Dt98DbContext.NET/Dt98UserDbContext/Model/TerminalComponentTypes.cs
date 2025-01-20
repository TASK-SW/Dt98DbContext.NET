using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(Id))]
   [Table("_sctTERMINALCOMPONENTTYPES")]
   public class TerminalComponentTypes
   {
      #region Public Constructors

       public TerminalComponentTypes()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("ID")]
       public int Id { get; set; }

       [Column("NAME")]
       public string Name { get; set; }


       #endregion Public Properties
   }
}
