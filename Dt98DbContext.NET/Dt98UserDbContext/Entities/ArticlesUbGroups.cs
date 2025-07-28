using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class ArticleSubGroups
    {
        #region Public Constructors

        public ArticleSubGroups()
        { }

        #endregion Public Constructors

        #region Public Properties

        public string OidSubGroups { get; set; }

        public string OidArtGrp { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public int Minage { get; set; }

        #endregion Public Properties
    }
}