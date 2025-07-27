using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(Oid))]
    [Table("_sptCARDDATACOM")]
    public class CardDataCom
    {
        #region Public Constructors

        public CardDataCom()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        [Column("OID")]
        public string Oid { get; set; }

        [Column("DT_CARD_TYPE_ID")]
        public string DtCardTypeId { get; set; }

        [Column("DT_ROUND_OPTOTAL")]
        public int DtRoundOpTotal { get; set; }

        [Column("DT_ROUND_TRX")]
        public int DtRoundTrx { get; set; }

        [Column("DT_XMIT_LIMIT_OUTDOOR")]
        public int DtXmitLimitOutdoor { get; set; }

        [Column("DT_LIMIT_OUTDOOR")]
        public int DtLimitOutdoor { get; set; }

        [Column("DT_LIMIT_TOTAL")]
        public int DtLimitTotal { get; set; }

        [Column("DT_ACCEPTANCE")]
        public int DtAcceptance { get; set; }

        [Column("DT_XMIT_ONLINE_AUTH")]
        public int DtXmitOnlineAuth { get; set; }

        [Column("DT_ONLINE_AUTH")]
        public int DtOnlineAuth { get; set; }

        [Column("DT_XMIT_PIN_AUTH")]
        public int DtXmitPinAuth { get; set; }

        [Column("DT_PIN_AUTH")]
        public int DtPinAuth { get; set; }

        [Column("PAN_STRIP_BLACKLIST")]
        public int PanStripBlackList { get; set; }

        [Column("PAN_STRIP_TRANSACT")]
        public int PanStripTransAct { get; set; }

        [Column("TRXDELIVMASK")]
        public int TrxDelivMask { get; set; }

        #endregion Public Properties
    }
}