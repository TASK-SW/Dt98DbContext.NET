namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("BLACKLIST001")]
    public class BlackList_001
    {
        #region Public Constructors

        public BlackList_001()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
        public string Oid { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("OID_BLACKLIST")]
        public string OidBlackList { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("LOWERPAN")]
        public string LowerPAN { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("UPPERPAN")]
        public string UpperPAN { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("WITHDRAW")]
        public int WithDraw { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("MUTATOR")]
        public int Mutator { get; set; }

        #endregion Public Properties
    }
}