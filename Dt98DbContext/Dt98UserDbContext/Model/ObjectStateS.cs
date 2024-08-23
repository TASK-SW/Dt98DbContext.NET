using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("OBJECTSTATES")]
   public class ObjectStates
   {
      #region Public Constructors

       public ObjectStates()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OBJTYPE")]
       public int Objtype { get; set; }

       [Key, Column(Order = 1)]
       //[Column("OBJID")]
       public string ObjId { get; set; }

       [Key, Column(Order = 2)]
       //[Column("PARTYPE")]
       public int PArtype { get; set; }

       [Key, Column(Order = 3)]
       //[Column("PARID")]
       public string ParId { get; set; }

       [Column("STATE")]
       public int State { get; set; }

       [Key, Column(Order = 4)]
       //[Column("OBJSTATEIX")]
       public int ObjStateIX { get; set; }


       #endregion Public Properties
   }
}
