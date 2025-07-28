using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class DevValType
    {
        #region Private Fields

        [NotMapped]
        private readonly ILazyLoader LazyLoader;

        private ICollection<DevSetting> _devSettings;

        #endregion Private Fields

        #region Public Constructors

        public DevValType()
        { }

        public DevValType(ILazyLoader lazyLoader)
        {
            LazyLoader = lazyLoader;
        }

        #endregion Public Constructors

        #region Public Properties

        public int IdValType { get; set; }
        public string NmValType { get; set; }

        public ICollection<DevSetting> DevSettings
        {
            get => LazyLoader.Load(this, ref _devSettings);
            set => _devSettings = value;
        }

        #endregion Public Properties
    }
}