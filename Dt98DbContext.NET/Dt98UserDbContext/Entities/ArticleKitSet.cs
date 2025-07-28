using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class ArticleKitSet
    {
        #region Public Constructors

        public ArticleKitSet()
        { }

        #endregion Public Constructors

        #region Public Properties

        public string OidParent { get; set; }

        public string OidChild { get; set; }

        public int Count { get; set; }

        #endregion Public Properties
    }
}