//==================================================================================================
//  FILE        :   SALESHEADER.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("SALESHEADER")]
   public class SalesHeader
   {
      #region Public Constructors

       public SalesHeader()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DATETIME")]
       public DateTime DateTime { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TERMINALID")]
       public string TerminalId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ACCOUNT")]
       public string Account { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CARDNUMBER")]
       public string CardNumber { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_STORNO_ORIGIN")]
       public string OidStornoOrigin { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("STORNOTYPE")]
       public int StornoType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ID_STR_RT")]
       public int IdSTRRT { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ID_WS")]
       public int IdWS { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ID_OPR")]
       public int IdOPR { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TS_TM_SRT")]
       public DateTime Tstmsrt { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("AMT_RND")]
       public decimal Amtrnd { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("AMT_RCV")]
       public decimal Amtrcv { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("AMT_RTN")]
       public decimal Amtrtn { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FRGN_ID_CNY")]
       public int FRGNIdCNY { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FRGN_SY_CNY")]
       public string Frgnsycny { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FRGN_EXCHG_RATE_RCV")]
       public decimal FRGNEXCHGRateRCV { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FRGN_EXCHG_RATE_RTN")]
       public decimal FRGNEXCHGRateRTN { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FRGN_EXCHG_FEE")]
       public decimal Frgnexchgfee { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FRGN_AMT_SALE")]
       public decimal FRGNAMTSale { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FRGN_AMT_RCV")]
       public decimal Frgnamtrcv { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FRGN_AMT_RTN")]
       public decimal Frgnamtrtn { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DSC_TYPE")]
       public int DSCType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DSC_RATE")]
       public decimal DSCRate { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DSC_AMT")]
       public decimal Dscamt { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("AUTH_INFO")]
       public string AuthInfo { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CARDPROCOID")]
       public string CardPROCOid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FUNDINGINFO")]
       public string FundingInfo { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DSC_TYPE_ID")]
       public string DSCTypeId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DSC_TYPE_NAME")]
       public string DSCTypeName { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DSC_REF_NO")]
       public string Dscrefno { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FRGN_TY_TND")]
       public string Frgntytnd { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FRGN_LOCAL_AMT_RND")]
       public decimal FRGNLocalAMTRND { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FRGN_DE_TND")]
       public string Frgndetnd { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("SECOND_CARD")]
       public string SecondCard { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("MATCH_CODE")]
       public string MatchCode { get; set; }


       #endregion Public Properties
   }
}
