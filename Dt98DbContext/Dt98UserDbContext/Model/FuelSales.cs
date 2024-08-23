using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("FUELSALES")]
   public class FuelSales
   {
      #region Public Constructors

       public FuelSales()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public string Oid { get; set; }

       [Column("DATETIME")]
       public DateTime DateTime { get; set; }

       [Column("STATE")]
       public int State { get; set; }

       [Column("TERMINALID")]
       public string TerminalId { get; set; }

       [Column("ACCOUNT")]
       public string Account { get; set; }

       [Column("CARDNUMBER")]
       public string CardNumber { get; set; }

       [Column("ARTICLEID")]
       public string ArticleId { get; set; }

       [Column("ARTICLE")]
       public string Article { get; set; }

       [Column("SHORTNAME")]
       public string ShortName { get; set; }

       [Column("RECEIPTTEXT")]
       public string ReceiptText { get; set; }

       [Column("QUANTITY")]
       public decimal Quantity { get; set; }

       [Column("UNITPRICE")]
       public decimal UnitPrice { get; set; }

       [Column("TAX")]
       public decimal Tax { get; set; }

       [Column("FPID")]
       public int FpId { get; set; }

       [Column("NOZZLEID")]
       public int NozzleId { get; set; }

       [Column("FPAMOUNT")]
       public decimal FpAmount { get; set; }

       [Column("ARTSUBGRP")]
       public string ArtSubGrp { get; set; }

       [Column("ARTGRP")]
       public string ArtGrp { get; set; }

       [Column("UNIT")]
       public int Unit { get; set; }

       [Column("VIDEO_SEQ_NO")]
       public int VideosEqNo { get; set; }

       [Column("FP_CRC")]
       public int FpCrc { get; set; }

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

       [Column("DT_AUTHORIZE")]
       public DateTime DtAuthorize { get; set; }

       [Column("DT_START")]
       public DateTime DtStart { get; set; }

       [Column("DT_END")]
       public DateTime DtEnd { get; set; }

       [Column("SECOND_CARD")]
       public string SecondCard { get; set; }

       [Column("TI_CONFIG")]
       public string TiConfig { get; set; }


       #endregion Public Properties
   }
}
