using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    //===[===PrimaryKey(nameof(Pan))]
   [Table("REDLIST001")]
   public class RedList001
   {
      #region Public Constructors

       public RedList001()
      {
      }

        #endregion Public Constructors

        #region Public Properties

        [Key]
        [Column("PAN")]
       public string Pan { get; set; }

       [Column("COUNT")]
       public int Count { get; set; }

       [Column("EDITDATE")]
       public DateTime EditDate { get; set; }


       #endregion Public Properties
   }
}
