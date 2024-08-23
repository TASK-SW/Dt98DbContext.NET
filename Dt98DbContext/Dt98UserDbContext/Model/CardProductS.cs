using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("_sptCARDPRODUCTS")]
   public class CardProducts
   {
      #region Public Constructors

       public CardProducts()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public string Oid { get; set; }

       [Column("OID_CARDTYPE")]
       public string OidCardType { get; set; }

       [Column("SERVICECODE")]
       public int ServiceCode { get; set; }

       [Column("SERVICEVALUE")]
       public int ServiceValue { get; set; }

       [Column("PRODUCTS")]
       public string Products { get; set; }


       #endregion Public Properties
   }
}
