using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("_sctPAYMENTTYPES")]
   public class PaymentTypes
   {
      #region Public Constructors

       public PaymentTypes()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public string Oid { get; set; }

       [Column("NAME")]
       public string Name { get; set; }


       #endregion Public Properties
   }
}
