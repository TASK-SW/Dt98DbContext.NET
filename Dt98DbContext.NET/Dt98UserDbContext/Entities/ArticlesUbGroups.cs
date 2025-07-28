using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class ArticleSubGroups
    {
        #region Private Fields

        private readonly ILazyLoader LazyLoader;

        private ICollection<Articles> _articles;

        #endregion Private Fields

        #region Public Constructors

        public ArticleSubGroups()
        { }

        public ArticleSubGroups(ILazyLoader lazyLoader)
        {
            LazyLoader = lazyLoader;
        }

        #endregion Public Constructors

        #region Public Properties

        public ICollection<Articles> Articles
        {
            get => LazyLoader.Load(this, ref _articles);
            set => _articles = value;
        }

        public ArticleGroups Group { get; set; }

        public string OidSubGroups { get; set; }

        public string OidArtGrp { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public int Minage { get; set; }

        #endregion Public Properties
    }
}