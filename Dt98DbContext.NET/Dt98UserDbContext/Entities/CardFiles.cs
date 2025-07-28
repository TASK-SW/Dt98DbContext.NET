using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    //===[===PrimaryKey(nameof(Oid))]
   [Table("_sptCARDFILES")]
   public class CardFiles
   {
      #region Public Constructors

       public CardFiles()
      {
      }

        #endregion Public Constructors

        #region Public Properties

        //FK : CardTypes.Oid
        [Key]
        [Column("OID")]
       public string Oid { get; set; }

        //FK : BlackLists.Oid
        [Column("OID_BLACKLIST")]
       public string OidBlackList { get; set; }

        //FK : GreyLists.Oid
        [Column("OID_GREYLIST")]
       public string OidGreyList { get; set; }

        //FK : RedLists.Oid
        [Column("OID_REDLIST")]
       public string OidRedList { get; set; }

        //FK : CardDlyTotals.Oid
        [Column("OID_CARDDLYTOTAL")]
       public string OidCardDlyTotal { get; set; }

        //FK : CardTrxCounts.Oid
        [Column("OID_CARDTRXCOUNT")]
       public string OidCardTrxCount { get; set; }

        //FK : TrxFiles.Oid
        [Column("OID_TRXFILE")]
       public string OidTrxFile { get; set; }

        //FK : Hosts.Oid
        [Column("OID_HOST")]
       public string OidHost { get; set; }

        //FK : CardDataCom.Oid
        [Column("OID_CARDDATACOM")]
       public string OidCardDataCom { get; set; }

       [Column("OID_FOREIGNTRX")]
       public string OidForeignTrx { get; set; }


       #endregion Public Properties
   }
}
