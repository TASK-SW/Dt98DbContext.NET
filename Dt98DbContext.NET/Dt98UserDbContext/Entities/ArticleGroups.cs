using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class ArticleGroups
    {
        #region Public Constructors

        public ArticleGroups()
        { }

        #endregion Public Constructors

        #region Public Properties

        public string Oid { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        #endregion Public Properties
    }
}