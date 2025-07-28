using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class DevConfig
    {
        #region Private Fields

        [NotMapped]
        private readonly ILazyLoader LazyLoader;

        private DevType _devType;

        private DevClass _devClass;

        private DevConfig _parentConfig;

        private ICollection<DevConfig> _childConfigs;

        private ICollection<DevSetting> _devSettings;

        #endregion Private Fields

        #region Public Constructors

        public DevConfig()
        { }

        public DevConfig(ILazyLoader lazyLoader)
        {
            LazyLoader = lazyLoader;
        }

        #endregion Public Constructors

        #region Public Properties

        public string IdDevCfg { get; set; }
        public string IdDevTyp { get; set; }
        public string IdDevCls { get; set; }
        public string IdDevPar { get; set; }

        public DevType DevType
        {
            get => LazyLoader.Load(this, ref _devType);
            set => _devType = value;
        }

        public DevClass DevClass
        {
            get => LazyLoader.Load(this, ref _devClass);
            set => _devClass = value;
        }

        public DevConfig ParentConfig
        {
            get => LazyLoader.Load(this, ref _parentConfig);
            set => _parentConfig = value;
        }

        public ICollection<DevConfig> ChildConfigs
        {
            get => LazyLoader.Load(this, ref _childConfigs);
            set => _childConfigs = value;
        }

        public ICollection<DevSetting> DevSettings
        {
            get => LazyLoader.Load(this, ref _devSettings);
            set => _devSettings = value;
        }

        #endregion Public Properties
    }
}