using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("VMA_HostStates")]
   public class VmaHostStates
   {
      #region Public Constructors

       public VmaHostStates()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("HostId")]
       public int HostId { get; set; }

       [Key, Column(Order = 1)]
       //[Column("StateKey")]
       public string StateKey { get; set; }

       [Column("StateValue")]
       public string StateValue { get; set; }


       #endregion Public Properties
   }
}
