using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("REDLIST045")]
   public class RedList045
   {
      #region Public Constructors

       public RedList045()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("PAN")]
       public string Pan { get; set; }

       [Column("COUNT")]
       public int Count { get; set; }

       [Column("EDITDATE")]
       public DateTime EditDate { get; set; }


       #endregion Public Properties
   }
}
