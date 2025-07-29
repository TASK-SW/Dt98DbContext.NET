using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class Taxes
    {
        #region Private Fields

        private readonly ILazyLoader LazyLoader;

        private ICollection<Articles> _articles;

        #endregion Private Fields

        #region Public Constructors

        public Taxes()
        {
        }

        public Taxes(ILazyLoader lazyLoader)
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

        public string OidTaxes { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Tax { get; set; }

        #endregion Public Properties
    }
}