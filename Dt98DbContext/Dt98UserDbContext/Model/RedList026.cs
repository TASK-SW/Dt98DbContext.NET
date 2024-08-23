using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("REDLIST026")]
   public class RedList026
   {
      #region Public Constructors

       public RedList026()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("PAN")]
       public string Pan { get; set; }

       [Column("COUNT")]
       public int Count { get; set; }

       [Column("EDITDATE")]
       public DateTime EditDate { get; set; }


       #endregion Public Properties
   }
}
