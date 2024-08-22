namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("_sptCARDFILES")]
    public class CardFiles
    {
        #region Public Constructors

        public CardFiles()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
        public string Oid { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("OID_BLACKLIST")]
        public string OidBlackList { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("OID_GREYLIST")]
        public string OidGreyList { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("OID_REDLIST")]
        public string OidRedList { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("OID_CARDDLYTOTAL")]
        public string OidCardDLYTotal { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("OID_CARDTRXCOUNT")]
        public string OidCardTRXCount { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("OID_TRXFILE")]
        public string OidTRXFile { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("OID_HOST")]
        public string OidHost { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("OID_CARDDATACOM")]
        public string OidCardDataCom { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("OID_FOREIGNTRX")]
        public string OidForeignTRX { get; set; }

        #endregion Public Properties
    }
}