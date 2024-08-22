namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("_sptTRXFILES")]
    public class _sptTRXFILES
    {
        #region Public Constructors

        public _sptTRXFILES()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
        public string Oid { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("OID_TYPE")]
        public string OidType { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("ID")]
        public int Id { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("RESETDATE")]
        public DateTime RESetDate { get; set; }

        #endregion Public Properties
    }
}