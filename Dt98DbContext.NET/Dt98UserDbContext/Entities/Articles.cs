using System;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class Articles
    {
        #region Public Constructors

        public Articles()
        { }

        #endregion Public Constructors

        #region Public Properties

        public string Oid { get; set; }

        public string OidArtSubGrp { get; set; }

        public string OidTax { get; set; }

        public string Id { get; set; }

        public string EanCode { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }

        public string ReceiptText { get; set; }

        public decimal SalesPrice { get; set; }

        public int SalesUnit { get; set; }

        public decimal SalesQuantity { get; set; }

        public int NormUnit { get; set; }

        public decimal NormQuantity { get; set; }

        public decimal NormPrice { get; set; }

        public int VoucherEnabled { get; set; }

        public DateTime VoucherValIdFrom { get; set; }

        public DateTime VoucherValIdtO { get; set; }

        public int VoucherValIdDays { get; set; }

        public int VoucherThreshOld { get; set; }

        public decimal VoucherMinAmount { get; set; }

        public decimal VoucherDscPerLiter { get; set; }

        #endregion Public Properties
    }
}