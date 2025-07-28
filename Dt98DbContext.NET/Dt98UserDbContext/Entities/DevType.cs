using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class DevType
    {
        #region Private Fields

        private readonly ILazyLoader LazyLoader;

        private ICollection<DevConfig> _devConfigs;

        #endregion Private Fields

        #region Public Constructors

        public DevType()
        { }

        public DevType(ILazyLoader lazyLoader)
        {
            LazyLoader = lazyLoader;
        }

        #endregion Public Constructors

        #region Public Properties

        public string IdDevTyp { get; set; }

        public string IdDevCls { get; set; }

        public string NmdevTyp { get; set; }

        public string ClsIdDevTyp { get; set; }

        public ICollection<DevConfig> DevConfigs
        {
            get => LazyLoader.Load(this, ref _devConfigs);
            set => _devConfigs = value;
        }

        #endregion Public Properties
    }
}