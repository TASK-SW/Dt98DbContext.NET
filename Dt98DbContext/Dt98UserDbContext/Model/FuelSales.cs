//==================================================================================================
//  FILE        :   FUELSALES.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("FUELSALES")]
   public class FuelSales
   {
      #region Public Constructors

       public FuelSales()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DATETIME")]
       public DateTime DateTime { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("STATE")]
       public int State { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TERMINALID")]
       public string TerminalId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ACCOUNT")]
       public string Account { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CARDNUMBER")]
       public string CardNumber { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ARTICLEID")]
       public string ArticleId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ARTICLE")]
       public string Article { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("SHORTNAME")]
       public string ShortName { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("RECEIPTTEXT")]
       public string ReceiptText { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("QUANTITY")]
       public decimal Quantity { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("UNITPRICE")]
       public decimal UnitPrice { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TAX")]
       public decimal TAX { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FPID")]
       public int FPId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("NOZZLEID")]
       public int NozzleId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FPAMOUNT")]
       public decimal FPAmount { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ARTSUBGRP")]
       public string ArtSubGrp { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ARTGRP")]
       public string ArtGrp { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("UNIT")]
       public int Unit { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("VIDEO_SEQ_NO")]
       public int VIdEOSEQNO { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("FP_CRC")]
       public int Fpcrc { get; set; }

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

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_AUTHORIZE")]
       public DateTime DTAuthorize { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_START")]
       public DateTime DTStart { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DT_END")]
       public DateTime DTEnd { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("SECOND_CARD")]
       public string SecondCard { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TI_CONFIG")]
       public string TIConfig { get; set; }


       #endregion Public Properties
   }
}
