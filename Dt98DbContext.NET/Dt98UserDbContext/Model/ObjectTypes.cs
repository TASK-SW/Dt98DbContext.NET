using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(Objtype))]
   [Table("_sctOBJECTTYPES")]
   public class ObjectTypes
   {
      #region Public Constructors

       public ObjectTypes()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OBJTYPE")]
       public int Objtype { get; set; }

       [Column("OBJTYPENAME")]
       public string ObjtypeName { get; set; }


       #endregion Public Properties
   }
}
