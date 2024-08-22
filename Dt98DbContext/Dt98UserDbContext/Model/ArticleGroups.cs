namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("ARTICLEGROUPS")]
    public class ArticleGroups
    {
        #region Public Constructors

        public ArticleGroups()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
        public string Oid { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("ID")]
        public string Id { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("NAME")]
        public string Name { get; set; }

        #endregion Public Properties
    }
}