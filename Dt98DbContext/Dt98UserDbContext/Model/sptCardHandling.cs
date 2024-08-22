//==================================================================================================
//  FILE        :   _sptCARDHANDLING.cs
//  PROJECT     :   TaskStar.DT98UserEF6DbContext.DT98UserDbContext.Model
//  COPYRIGHT   :   (C) 2011, TASK Technology Gmbh, Germany
//  AUTHOR(s)   :   af              Andrej Froschgeiser
//  HISTORY     :   01.00.00.01     19.07.2024af01   creation
//==================================================================================================

using System;
using System.Collections.Generic;

namespace TaskStar.Dt98DbContext.Dt98UserDbContext.Model
{
   [System.ComponentModel.DataAnnotations.Schema.Table("_sptCARDHANDLING")]
   public class sptCardHandling
   {
      #region Public Constructors

       public sptCardHandling()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [System.ComponentModel.DataAnnotations.Key]
       [System.ComponentModel.DataAnnotations.Schema.Column("OID")]
       public string Oid { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CHK_LUHN")]
       public int CHKLUHN { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CHK_DATE")]
       public int CHKDate { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PIN_CHECKTYPE")]
       public int PINCheckType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PIN_SCPOS")]
       public int PINSCPos { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PIN_SCVAL")]
       public int PINSCVal { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("LIMIT_MIN")]
       public int LimitMin { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("LIMIT_FLOOR1")]
       public int LimitFloor1 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("LIMIT_FLOOR2")]
       public int LimitFloor2 { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PROCESSINGTYPE")]
       public int ProcessingType { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("DEFAULTAMOUNT")]
       public int DEFAULTAmount { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("LIMIT_DATEFROM")]
       public int LimitDateFrom { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("LIMIT_DATETO")]
       public int LimitDateTO { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PIN_SKIP")]
       public int PINSkip { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("LENVERIFYNO")]
       public int LENVERIFYNO { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("CHK_CARDLEN")]
       public int CHKCardLEN { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("LIMIT_TOTALAMOUNT")]
       public int LimitTotalAmount { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("LIMIT_OUTDOORAMOUNT")]
       public int LimitOutdoorAmount { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("COUNTKEYCARDS")]
       public int CountKeyCardS { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("KEYPOS")]
       public int KeyPos { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("ISSUERLEN")]
       public int ISSUERLEN { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("MODE")]
       public int Mode { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("TERMCODETABID")]
       public int TermCodeTabId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("PRODCODETABID")]
       public int ProdCodeTabId { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("RECEIPTCOUNT")]
       public int ReceiptCount { get; set; }

       [System.ComponentModel.DataAnnotations.Schema.Column("OID_KEYCARDHANDLING")]
       public string OidKeyCardHandling { get; set; }


       #endregion Public Properties
   }
}
