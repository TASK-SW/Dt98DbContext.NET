namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("BLACKLIST_LOCAL_0001S")]
    public class BlackListLocal0001S
    {
        #region Public Constructors

        public BlackListLocal0001S()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
        public int Oid { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("PAN")]
        public string PAN { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("WITHDRAW")]
        public int WithDraw { get; set; }

        #endregion Public Properties
    }
}