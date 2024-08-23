using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("_sptCARDTRACKS")]
   public class CardTracks
   {
      #region Public Constructors

       public CardTracks()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public string Oid { get; set; }

       [Column("OID_CARDPROFILE")]
       public string OidCardProfile { get; set; }

       [Column("TRACKPOS")]
       public int TrackPos { get; set; }

       [Column("LOWVAL")]
       public int LowVal { get; set; }

       [Column("UPVAL")]
       public int UpVal { get; set; }

       [Column("CONDITION")]
       public int Condition { get; set; }


       #endregion Public Properties
   }
}
