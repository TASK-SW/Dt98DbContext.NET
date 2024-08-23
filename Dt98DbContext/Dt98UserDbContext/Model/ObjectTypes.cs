using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("_sctOBJECTTYPES")]
   public class ObjectTypes
   {
      #region Public Constructors

       public ObjectTypes()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OBJTYPE")]
       public int Objtype { get; set; }

       [Column("OBJTYPENAME")]
       public string ObjtypeName { get; set; }


       #endregion Public Properties
   }
}
