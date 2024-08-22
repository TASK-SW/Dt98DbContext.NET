namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
    [System.ComponentModel.DataAnnotations.Schema.Table("ARTICLESUBGROUPS")]
    public class ArticlesUBGroups
    {
        #region Public Constructors

        public ArticlesUBGroups()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
        public string Oid { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("OID_ARTGRP")]
        public string OidArtGrp { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("ID")]
        public string Id { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("NAME")]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("MIN_AGE")]
        public int Minage { get; set; }

        #endregion Public Properties
    }
}