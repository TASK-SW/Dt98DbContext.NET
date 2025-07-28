using System;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    public class SalesHeader
    {
        #region Public Constructors

        public SalesHeader()
        {
        }

        #endregion Public Constructors

        #region Public Properties

        public string Oid { get; set; }
        public DateTime DateTime { get; set; }
        public string TerminalId { get; set; }
        public string Account { get; set; }
        public string CardNumber { get; set; }
        public string OidStornoOrigin { get; set; }
        public int StornoType { get; set; }
        public int IdStrRt { get; set; }
        public int IdWs { get; set; }
        public int IdopR { get; set; }
        public DateTime TsTmSRt { get; set; }
        public decimal AmtRnd { get; set; }
        public decimal AmtRcv { get; set; }
        public decimal AmtRtn { get; set; }
        public int FrgnIdCny { get; set; }
        public string FrgnSyCny { get; set; }
        public decimal FrgnExchgRateRcv { get; set; }
        public decimal FrgnExchgRateRtn { get; set; }
        public decimal FrgnExchgFee { get; set; }
        public decimal FrgnAmtSale { get; set; }
        public decimal FrgnAmtRcv { get; set; }
        public decimal FrgnAmtRtn { get; set; }
        public int DscType { get; set; }
        public decimal DscRate { get; set; }
        public decimal DscAmt { get; set; }
        public string AuthInfo { get; set; }
        public string CardProcOid { get; set; }
        public string FundingInfo { get; set; }
        public string DscTypeId { get; set; }
        public string DscTypeName { get; set; }
        public string DscRefNo { get; set; }
        public string FrgnTyTnd { get; set; }
        public decimal FrgnLocalAmtRnd { get; set; }
        public string FrgnDeTnd { get; set; }
        public string SecondCard { get; set; }
        public string MatchCode { get; set; }

        #endregion Public Properties
    }
}