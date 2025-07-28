using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.NET.Dt98UserDbContext.Entities
{
    //===[===PrimaryKey(nameof(VoucherCode), nameof(VoucherType), nameof(EanCode))]
   [Table("CodeVouchers")]
   public class CodeVouchers
   {
      #region Public Constructors

       public CodeVouchers()
      {
      }

        #endregion Public Constructors

        #region Public Properties

        [Key]
        [Column("VoucherCode")]
       public int VoucherCode { get; set; }

        [Key]
        [Column("VoucherType")]
       public int VoucherType { get; set; }

       [Column("ItemId")]
       public int ItemId { get; set; }

       [Column("ParValue")]
       public decimal ParValue { get; set; }

       [Column("ExpirationDate")]
       public DateTime ExpirationDate { get; set; }

       [Column("RedemptionDate")]
       public DateTime RedemptionDate { get; set; }

        [Key]
        [Column("EANCode")]
       public string EanCode { get; set; }

       [Column("ValidFromDate")]
       public DateTime ValidFromDate { get; set; }

       [Column("CreationSiteId")]
       public int CreationSiteId { get; set; }

       [Column("CreationDate")]
       public DateTime CreationDate { get; set; }

       [Column("IsScanned")]
       public int IsScanned { get; set; }

       [Column("VoucherSeqNo")]
       public int VoucherSeqNo { get; set; }


       #endregion Public Properties
   }
}
