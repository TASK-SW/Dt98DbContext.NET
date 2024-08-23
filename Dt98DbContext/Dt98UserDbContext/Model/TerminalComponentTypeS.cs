using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("_sctTERMINALCOMPONENTTYPES")]
   public class TerminalComponentTypes
   {
      #region Public Constructors

       public TerminalComponentTypes()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("ID")]
       public int Id { get; set; }

       [Column("NAME")]
       public string Name { get; set; }


       #endregion Public Properties
   }
}
