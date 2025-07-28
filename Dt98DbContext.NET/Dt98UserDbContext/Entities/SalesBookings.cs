using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class SalesBookings
    {
        #region Public Constructors

        public SalesBookings()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public string Oid { get; set; }
        public string OidSales { get; set; }
        public string ArticleId { get; set; }
        public string Article { get; set; }
        public string ShortName { get; set; }
        public string ReceiptText { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Tax { get; set; }
        public int FpId { get; set; }
        public int NozzleId { get; set; }
        public decimal FpAmount { get; set; }
        public string ArtSubGrp { get; set; }
        public string ArtGrp { get; set; }
        public int Unit { get; set; }
        public string OidStornoOrigin { get; set; }
        public int DscType { get; set; }
        public decimal DscRate { get; set; }
        public decimal DscAmt { get; set; }
        public string EanCode { get; set; }
        public int VideosEqNo { get; set; }
        public int FpCrc { get; set; }
        public DateTime DtAuthorize { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime DtEnd { get; set; }
        public string TiConfig { get; set; }
        public int FrgnIdCny { get; set; }
        public decimal FrgnUnitPrc { get; set; }

        #endregion Public Properties
    }
}