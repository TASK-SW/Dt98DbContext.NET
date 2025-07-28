using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    //===[===PrimaryKey(nameof(Pan))]
   [Table("CARDTRXCOUNT002")]
   public class CardTrxCount002
   {
      #region Public Constructors

       public CardTrxCount002()
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
