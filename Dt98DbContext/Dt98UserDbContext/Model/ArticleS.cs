using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
   [Table("ARTICLES")]
   public class Articles
   {
      #region Public Constructors

       public Articles()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Key, Column(Order = 0)]
       //[Column("OID")]
       public string Oid { get; set; }

       [Column("OID_ARTSUBGRP")]
       public string OidArtSubGrp { get; set; }

       [Column("OID_TAX")]
       public string OidTax { get; set; }

       [Column("ID")]
       public string Id { get; set; }

       [Column("EANCODE")]
       public string EanCode { get; set; }

       [Column("NAME")]
       public string Name { get; set; }

       [Column("SHORTNAME")]
       public string ShortName { get; set; }

       [Column("RECEIPTTEXT")]
       public string ReceiptText { get; set; }

       [Column("SALES_PRICE")]
       public decimal SalesPrice { get; set; }

       [Column("SALES_UNIT")]
       public int SalesUnit { get; set; }

       [Column("SALES_QUANTITY")]
       public decimal SalesQuantity { get; set; }

       [Column("NORM_UNIT")]
       public int NormUnit { get; set; }

       [Column("NORM_QUANTITY")]
       public decimal NormQuantity { get; set; }

       [Column("NORM_PRICE")]
       public decimal NormPrice { get; set; }

       [Column("VOUCHER_ENABLED")]
       public int VoucherEnabled { get; set; }

       [Column("VOUCHER_VALID_FROM")]
       public DateTime VoucherValIdFrom { get; set; }

       [Column("VOUCHER_VALID_TO")]
       public DateTime VoucherValIdtO { get; set; }

       [Column("VOUCHER_VALID_DAYS")]
       public int VoucherValIdDays { get; set; }

       [Column("VOUCHER_THRESHOLD")]
       public int VoucherThreshOld { get; set; }

       [Column("VOUCHER_MIN_AMOUNT")]
       public decimal VoucherMinAmount { get; set; }

       [Column("VOUCHER_DSC_PER_LITER")]
       public decimal VoucherDscPerLiter { get; set; }


       #endregion Public Properties
   }
}
