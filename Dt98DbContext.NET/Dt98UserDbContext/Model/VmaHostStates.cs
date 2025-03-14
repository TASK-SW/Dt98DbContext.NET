using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(HostId), nameof(StateKey))]
   [Table("VMA_HostStates")]
   public class VmaHostStates
   {
      #region Public Constructors

       public VmaHostStates()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("HostId")]
       public int HostId { get; set; }

       [Column("StateKey")]
       public string StateKey { get; set; }

       [Column("StateValue")]
       public string StateValue { get; set; }


       #endregion Public Properties
   }
}
