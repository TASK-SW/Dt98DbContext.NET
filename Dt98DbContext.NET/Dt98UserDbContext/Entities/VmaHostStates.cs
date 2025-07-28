using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    //===[===PrimaryKey(nameof(HostId), nameof(StateKey))]
   [Table("VMA_HostStates")]
   public class VmaHostStates
   {
      #region Public Constructors

       public VmaHostStates()
      {
      }

        #endregion Public Constructors

        #region Public Properties

        [Key]
        [Column("HostId")]
       public int HostId { get; set; }

        [Key]
        [Column("StateKey")]
       public string StateKey { get; set; }

       [Column("StateValue")]
       public string StateValue { get; set; }


       #endregion Public Properties
   }
}
