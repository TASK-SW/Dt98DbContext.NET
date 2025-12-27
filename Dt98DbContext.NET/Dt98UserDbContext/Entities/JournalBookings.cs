using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class JournalBookings
    {
        #region Private Fields

        private readonly ILazyLoader _lazyLoader;

        private Units _units;

        private EanCodes _eanCodes;

        private ArticleSubGroups _subGroup;

        #endregion Private Fields

        #region Public Constructors

        public JournalBookings()
        { }

        public JournalBookings(ILazyLoader lazyLoader)
        {
            _lazyLoader = lazyLoader;
        }

        #endregion Public Constructors

        #region Public Properties

        public string OidBooking { get; set; }
        public string OidJournal { get; set; }
        public JournalHeader Header { get; set; }

        public int? BookingId { get; set; }
        public string ArticleId { get; set; }
        public string Article { get; set; }
        public string ShortName { get; set; }
        public string ReceiptText { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Tax { get; set; }
        public int? FpId { get; set; }
        public int? NozzleId { get; set; }
        public decimal? FpAmount { get; set; }
        public string ArtSubGrp { get; set; }
        public string ArtGrp { get; set; }

        public int? Unit { get; set; }

        // 👇 Lazy-loaded navigation property using ILazyLoader
        public Units Units
        {
            get => _lazyLoader?.Load(this, ref _units);
            set => _units = value;
        }

        // 👇 Lazy-loaded navigation property using ILazyLoader
        public EanCodes EanCodes
        {
            get => _lazyLoader?.Load(this, ref _eanCodes);
            set => _eanCodes = value;
        }

        // 👇 Lazy-loaded navigation property using ILazyLoader
        public ArticleSubGroups SubGroup
        {
            get => _lazyLoader?.Load(this, ref _subGroup);
            set => _subGroup = value;
        }

        public string OidStornoOrigin { get; set; }
        public int? DscType { get; set; }
        public decimal? DscRate { get; set; }
        public decimal? DscAmt { get; set; }
        public string EanCode { get; set; }
        public int? VideosEqNo { get; set; }
        public int? FpCrc { get; set; }
        public int? FrgnIdCny { get; set; }
        public decimal? FrgnUnitPrc { get; set; }

        #endregion Public Properties
    }
}