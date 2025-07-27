using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(Oid))]
   [Table("_sptCARDFILES")]
   public class CardFiles
   {
      #region Public Constructors

       public CardFiles()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
       public string Oid { get; set; }

       [Column("OID_BLACKLIST")]
       public string OidBlackList { get; set; }

       [Column("OID_GREYLIST")]
       public string OidGreyList { get; set; }

       [Column("OID_REDLIST")]
       public string OidRedList { get; set; }

       [Column("OID_CARDDLYTOTAL")]
       public string OidCardDlyTotal { get; set; }

       [Column("OID_CARDTRXCOUNT")]
       public string OidCardTrxCount { get; set; }

       [Column("OID_TRXFILE")]
       public string OidTrxFile { get; set; }

       [Column("OID_HOST")]
       public string OidHost { get; set; }

       [Column("OID_CARDDATACOM")]
       public string OidCardDataCom { get; set; }

       [Column("OID_FOREIGNTRX")]
       public string OidForeignTrx { get; set; }


       #endregion Public Properties
   }
}
