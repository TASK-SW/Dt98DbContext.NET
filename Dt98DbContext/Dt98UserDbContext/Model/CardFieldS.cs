namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("_sptCARDFIELDS")]
    public class CardFieldS
    {
        #region Public Constructors

        public CardFieldS()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
        public string Oid { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("OID_TYPE")]
        public string OidType { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("FIELDID")]
        public int FieldId { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("POSITION")]
        public int Position { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("LENGTH")]
        public int Length { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("CHECKOPTION")]
        public int CheckOption { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("MINSIZE")]
        public int MinSize { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("MAXSIZE")]
        public int MaxSize { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("TEXTID")]
        public int TextId { get; set; }

        #endregion Public Properties
    }
}