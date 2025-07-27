using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    [PrimaryKey(nameof(Oid))]
   [Table("SALESHEADER")]
   public class SalesHeader
   {
      #region Public Constructors

       public SalesHeader()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
       public string Oid { get; set; }

       [Column("DATETIME")]
       public DateTime DateTime { get; set; }

       [Column("TERMINALID")]
       public string TerminalId { get; set; }

       [Column("ACCOUNT")]
       public string Account { get; set; }

       [Column("CARDNUMBER")]
       public string CardNumber { get; set; }

       [Column("OID_STORNO_ORIGIN")]
       public string OidStornoOrigin { get; set; }

       [Column("STORNOTYPE")]
       public int StornoType { get; set; }

       [Column("ID_STR_RT")]
       public int IdStrRt { get; set; }

       [Column("ID_WS")]
       public int IdWs { get; set; }

       [Column("ID_OPR")]
       public int IdopR { get; set; }

       [Column("TS_TM_SRT")]
       public DateTime TsTmSRt { get; set; }

       [Column("AMT_RND")]
       public decimal AmtRnd { get; set; }

       [Column("AMT_RCV")]
       public decimal AmtRcv { get; set; }

       [Column("AMT_RTN")]
       public decimal AmtRtn { get; set; }

       [Column("FRGN_ID_CNY")]
       public int FrgnIdCny { get; set; }

       [Column("FRGN_SY_CNY")]
       public string FrgnSyCny { get; set; }

       [Column("FRGN_EXCHG_RATE_RCV")]
       public decimal FrgnExchgRateRcv { get; set; }

       [Column("FRGN_EXCHG_RATE_RTN")]
       public decimal FrgnExchgRateRtn { get; set; }

       [Column("FRGN_EXCHG_FEE")]
       public decimal FrgnExchgFee { get; set; }

       [Column("FRGN_AMT_SALE")]
       public decimal FrgnAmtSale { get; set; }

       [Column("FRGN_AMT_RCV")]
       public decimal FrgnAmtRcv { get; set; }

       [Column("FRGN_AMT_RTN")]
       public decimal FrgnAmtRtn { get; set; }

       [Column("DSC_TYPE")]
       public int DscType { get; set; }

       [Column("DSC_RATE")]
       public decimal DscRate { get; set; }

       [Column("DSC_AMT")]
       public decimal DscAmt { get; set; }

       [Column("AUTH_INFO")]
       public string AuthInfo { get; set; }

       [Column("CARDPROCOID")]
       public string CardProcOid { get; set; }

       [Column("FUNDINGINFO")]
       public string FundingInfo { get; set; }

       [Column("DSC_TYPE_ID")]
       public string DscTypeId { get; set; }

       [Column("DSC_TYPE_NAME")]
       public string DscTypeName { get; set; }

       [Column("DSC_REF_NO")]
       public string DscRefNo { get; set; }

       [Column("FRGN_TY_TND")]
       public string FrgnTyTnd { get; set; }

       [Column("FRGN_LOCAL_AMT_RND")]
       public decimal FrgnLocalAmtRnd { get; set; }

       [Column("FRGN_DE_TND")]
       public string FrgnDeTnd { get; set; }

       [Column("SECOND_CARD")]
       public string SecondCard { get; set; }

       [Column("MATCH_CODE")]
       public string MatchCode { get; set; }


       #endregion Public Properties
   }
}
