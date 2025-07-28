using Microsoft.EntityFrameworkCore.Infrastructure;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class EanCodes
    {
        #region Private Fields

        private readonly ILazyLoader LazyLoader;

        private Articles _article;

        #endregion Private Fields

        #region Public Constructors

        public EanCodes()
        {
        }

        public EanCodes(ILazyLoader lazyLoader)
        {
            LazyLoader = lazyLoader;
        }

        #endregion Public Constructors

        #region Public Properties

        public Articles Article
        {
            get => LazyLoader.Load(this, ref _article);
            set => _article = value;
        }

        public string EanCode { get; set; }
        public string OidArticle { get; set; }
        public decimal SalesPrice { get; set; }

        #endregion Public Properties
    }
}