using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("_sptTOTALHANDLER")]
   public class TotalHandler
   {
      #region Public Constructors

       public TotalHandler()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("ID")]
       public string Id { get; set; }

       [Column("CLSID")]
       public string ClsId { get; set; }


       #endregion Public Properties
   }
}
