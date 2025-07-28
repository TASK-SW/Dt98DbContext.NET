using Microsoft.EntityFrameworkCore.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class DevSetting
    {
        #region Private Fields

        [NotMapped]
        private readonly ILazyLoader LazyLoader;

        private DevConfig _devConfig;

        private DevValType _valType;

        #endregion Private Fields

        #region Public Constructors

        public DevSetting()
        { }

        public DevSetting(ILazyLoader lazyLoader)
        {
            LazyLoader = lazyLoader;
        }

        #endregion Public Constructors

        #region Public Properties

        public string IdDevSet { get; set; }
        public string IdDevCfg { get; set; }
        public int TypDevSet { get; set; }
        public string ValDevSet { get; set; }

        public DevConfig DevConfig
        {
            get => LazyLoader.Load(this, ref _devConfig);
            set => _devConfig = value;
        }

        public DevValType ValType
        {
            get => LazyLoader.Load(this, ref _valType);
            set => _valType = value;
        }

        #endregion Public Properties
    }
}