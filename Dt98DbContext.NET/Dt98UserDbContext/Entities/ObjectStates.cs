using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    //===[===PrimaryKey(nameof(Objtype), nameof(ObjId), nameof(PArtype), nameof(ParId), nameof(State))]
   [Table("OBJECTSTATES")]
   public class ObjectStates
   {
      #region Public Constructors

       public ObjectStates()
      {
      }

        #endregion Public Constructors

        #region Public Properties

        [Key]
        [Column("OBJTYPE")]
       public int Objtype { get; set; }

        [Key]
        [Column("OBJID")]
       public string ObjId { get; set; }

        [Key]
        [Column("PARTYPE")]
       public int PArtype { get; set; }

        [Key]
        [Column("PARID")]
       public string ParId { get; set; }

        [Key]
        [Column("STATE")]
       public int State { get; set; }

       [Key, Column(Order = 4)]
       //[Column("OBJSTATEIX")]
       public int ObjStateIX { get; set; }


       #endregion Public Properties
   }
}
