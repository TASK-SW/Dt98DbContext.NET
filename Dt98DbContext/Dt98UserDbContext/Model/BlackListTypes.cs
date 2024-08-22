namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("_sctBLACKLISTTYPES")]
    public class BlackListTypes
    {
        #region Public Constructors

        public BlackListTypes()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
        public string Oid { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("ID")]
        public int Id { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("NAME")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("IID")]
        public string IId { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("CLSID")]
        public string CLSId { get; set; }

        #endregion Public Properties
    }
}