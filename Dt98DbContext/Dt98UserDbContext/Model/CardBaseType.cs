namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("_sctCARDBASETYPES")]
    public class CardBaseTypes
    {
        #region Public Constructors

        public CardBaseTypes()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
        public string Oid { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("NAME")]
        public string Name { get; set; }

        #endregion Public Properties
    }
}