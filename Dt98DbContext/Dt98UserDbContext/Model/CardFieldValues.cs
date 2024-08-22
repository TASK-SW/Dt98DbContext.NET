namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("_sptCARDFIELDVALUES")]
    public class CardFieldValues
    {
        #region Public Constructors

        public CardFieldValues()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
        public string Oid { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("OID_FIELD")]
        public string OidField { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("VALUE")]
        public string Value { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("CLSID")]
        public string CLSId { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("IID")]
        public string IId { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("INTERNALCODE")]
        public string InternalCode { get; set; }

        #endregion Public Properties
    }
}