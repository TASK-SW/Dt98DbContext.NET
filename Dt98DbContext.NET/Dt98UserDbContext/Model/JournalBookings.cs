using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(Oid))]
   [Table("JOURNALBOOKINGS")]
   public class JournalBookings
   {
      #region Public Constructors

       public JournalBookings()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
       public string Oid { get; set; }

       [Column("OID_JOURNAL")]
       public string OidJournal { get; set; }

       [Column("BOOKINGID")]
       public int BookingId { get; set; }

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

       [Column("OID_STORNO_ORIGIN")]
       public string OidStornoOrigin { get; set; }

       [Column("DSC_TYPE")]
       public int DscType { get; set; }

       [Column("DSC_RATE")]
       public decimal DscRate { get; set; }

       [Column("DSC_AMT")]
       public decimal DscAmt { get; set; }

       [Column("EANCODE")]
       public string EanCode { get; set; }

       [Column("VIDEO_SEQ_NO")]
       public int VideosEqNo { get; set; }

       [Column("FP_CRC")]
       public int FpCrc { get; set; }

       [Column("FRGN_ID_CNY")]
       public int FrgnIdCny { get; set; }

       [Column("FRGN_UNIT_PRC")]
       public decimal FrgnUnitPrc { get; set; }


       #endregion Public Properties
   }
}
