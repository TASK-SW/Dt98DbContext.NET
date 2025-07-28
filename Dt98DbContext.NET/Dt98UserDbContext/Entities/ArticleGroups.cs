using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class ArticleGroups
    {
        #region Private Fields

        private readonly ILazyLoader LazyLoader;

        private ICollection<ArticleSubGroups> _subGroups;

        #endregion Private Fields

        #region Public Constructors

        public ArticleGroups()
        { }

        public ArticleGroups(ILazyLoader lazyLoader)
        {
            LazyLoader = lazyLoader;
        }

        #endregion Public Constructors

        #region Public Properties

        public ICollection<ArticleSubGroups> SubGroups
        {
            get => LazyLoader.Load(this, ref _subGroups);
            set => _subGroups = value;
        }

        public string Oid { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        #endregion Public Properties
    }
}