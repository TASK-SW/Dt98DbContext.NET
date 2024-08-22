namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("ARTICLEKITSET")]
    public class ArticleKITSet
    {
        #region Public Constructors

        public ArticleKITSet()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        [System.ComponentModel.DataAnnotations.Schema.Column("OID_PARENT")]
        public string OidParent { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("OID_CHILD")]
        public string OidChild { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("COUNT")]
        public int Count { get; set; }

        #endregion Public Properties
    }
}