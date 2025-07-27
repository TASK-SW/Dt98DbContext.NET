using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(Oid))]
   [Table("_sptCARDPRODUCTS")]
   public class CardProducts
   {
      #region Public Constructors

       public CardProducts()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
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
