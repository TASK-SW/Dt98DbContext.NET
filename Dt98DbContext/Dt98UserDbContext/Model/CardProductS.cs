namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("_sptCARDPRODUCTS")]
    public class CardProductS
    {
        #region Public Constructors

        public CardProductS()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
        public string Oid { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("OID_CARDTYPE")]
        public string OidCardType { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("SERVICECODE")]
        public int ServiceCode { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("SERVICEVALUE")]
        public int ServiceValue { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("PRODUCTS")]
        public string ProductS { get; set; }

        #endregion Public Properties
    }
}