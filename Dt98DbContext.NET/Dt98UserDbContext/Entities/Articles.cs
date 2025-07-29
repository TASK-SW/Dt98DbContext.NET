using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class Articles
    {
        #region Private Fields

        private readonly ILazyLoader LazyLoader;

        private ArticleSubGroups _subGroup;

        private ICollection<EanCodes> _eanCodes;

        private Taxes _tax;

        #endregion Private Fields

        #region Public Constructors

        public Articles()
        { }

        public Articles(ILazyLoader lazyLoader)
        {
            LazyLoader = lazyLoader;
        }

        #endregion Public Constructors

        #region Public Properties

        public ICollection<EanCodes> EanCodes
        {
            get => LazyLoader.Load(this, ref _eanCodes);
            set => _eanCodes = value;
        }

        public Taxes Tax
        {
            get => LazyLoader.Load(this, ref _tax);
            set => _tax = value;
        }

        public ArticleSubGroups SubGroup
        {
            get => LazyLoader.Load(this, ref _subGroup);
            set => _subGroup = value;
        }

        public string Oid { get; set; }

        public string OidArtSubGrp { get; set; }

        public string OidTax { get; set; }

        public string Id { get; set; }

        public string EanCode { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }

        public string ReceiptText { get; set; }

        public decimal? SalesPrice { get; set; }

        public int? SalesUnit { get; set; }

        public decimal? SalesQuantity { get; set; }

        public int? NormUnit { get; set; }

        public decimal? NormQuantity { get; set; }

        public decimal? NormPrice { get; set; }

        public int? VoucherEnabled { get; set; }

        public DateTime? VoucherValIdFrom { get; set; }

        public DateTime? VoucherValIdtO { get; set; }

        public int? VoucherValIdDays { get; set; }

        public int? VoucherThreshOld { get; set; }

        public decimal? VoucherMinAmount { get; set; }

        public decimal? VoucherDscPerLiter { get; set; }

        #endregion Public Properties
    }
}