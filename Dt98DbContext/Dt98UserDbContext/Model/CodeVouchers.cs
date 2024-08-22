//==================================================================================================
//  FILE        :   CodeVouchers.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     22.08.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("CodeVouchers")]
   public class CodeVouchers
   {
      #region Public Constructors

       public CodeVouchers()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Schema.Column("VoucherCode")]
       public int VoucherCode { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("VoucherType")]
       public int VoucherType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ItemId")]
       public int ItemId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ParValue")]
       public decimal ParValue { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ExpirationDate")]
       public DateTime ExpirationDate { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("RedemptionDate")]
       public DateTime RedemptionDate { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("EANCode")]
       public string EanCode { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ValidFromDate")]
       public DateTime ValidFromDate { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CreationSiteId")]
       public int CreationSiteId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CreationDate")]
       public DateTime CreationDate { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("IsScanned")]
       public int IsScanned { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("VoucherSeqNo")]
       public int VoucherSeqNo { get; set; }


       #endregion Public Properties
   }
}
