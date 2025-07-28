using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class CodeVouchers
    {
        #region Public Constructors

        public CodeVouchers()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public int VoucherCode { get; set; }
        public int VoucherType { get; set; }
        public int ItemId { get; set; }
        public decimal ParValue { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime RedemptionDate { get; set; }
        public string EanCode { get; set; }
        public DateTime ValidFromDate { get; set; }
        public int CreationSiteId { get; set; }
        public DateTime CreationDate { get; set; }
        public int IsScanned { get; set; }
        public int VoucherSeqNo { get; set; }

        #endregion Public Properties
    }
}