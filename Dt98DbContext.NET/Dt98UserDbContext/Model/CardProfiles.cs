using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(Oid))]
   [Table("_sptCARDPROFILES")]
   public class CardProfiles
   {
      #region Public Constructors

       public CardProfiles()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
       public string Oid { get; set; }

       [Column("OID_CARD")]
       public string OidCard { get; set; }

       [Column("ID")]
       public int Id { get; set; }

       [Column("DATASOURCE")]
       public int DataSource { get; set; }

       [Column("COUNTERNO")]
       public int CountErNo { get; set; }


       #endregion Public Properties
   }
}
