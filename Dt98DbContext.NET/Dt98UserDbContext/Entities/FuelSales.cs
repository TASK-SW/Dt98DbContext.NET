using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class FuelSales
    {
        #region Public Constructors

        public FuelSales()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public string Oid { get; set; }
        public DateTime DateTime { get; set; }
        public int State { get; set; }
        public string TerminalId { get; set; }
        public string Account { get; set; }
        public string CardNumber { get; set; }
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
        public int VideosEqNo { get; set; }
        public int FpCrc { get; set; }
        public string CardProcOid { get; set; }
        public string FundingInfo { get; set; }
        public string DscTypeId { get; set; }
        public string DscTypeName { get; set; }
        public string DscRefNo { get; set; }
        public DateTime DtAuthorize { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime DtEnd { get; set; }
        public string SecondCard { get; set; }
        public string TiConfig { get; set; }

        #endregion Public Properties
    }
}