using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(Oid))]
   [Table("_sptCARDHANDLING")]
   public class CardHandling
   {
      #region Public Constructors

       public CardHandling()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
       public string Oid { get; set; }

       [Column("CHK_LUHN")]
       public int ChkLuhn { get; set; }

       [Column("CHK_DATE")]
       public int ChkDate { get; set; }

       [Column("PIN_CHECKTYPE")]
       public int PinCheckType { get; set; }

       [Column("PIN_SCPOS")]
       public int PinScPos { get; set; }

       [Column("PIN_SCVAL")]
       public int PinScVal { get; set; }

       [Column("LIMIT_MIN")]
       public int LimitMin { get; set; }

       [Column("LIMIT_FLOOR1")]
       public int LimitFloor1 { get; set; }

       [Column("LIMIT_FLOOR2")]
       public int LimitFloor2 { get; set; }

       [Column("PROCESSINGTYPE")]
       public int ProcessingType { get; set; }

       [Column("DEFAULTAMOUNT")]
       public int DefaultAmount { get; set; }

       [Column("LIMIT_DATEFROM")]
       public int LimitDateFrom { get; set; }

       [Column("LIMIT_DATETO")]
       public int LimitDateTo { get; set; }

       [Column("PIN_SKIP")]
       public int PinSkip { get; set; }

       [Column("LENVERIFYNO")]
       public int LenVerifyNo { get; set; }

       [Column("CHK_CARDLEN")]
       public int ChkCardLen { get; set; }

       [Column("LIMIT_TOTALAMOUNT")]
       public int LimitTotalAmount { get; set; }

       [Column("LIMIT_OUTDOORAMOUNT")]
       public int LimitOutdoorAmount { get; set; }

       [Column("COUNTKEYCARDS")]
       public int CountKeyCards { get; set; }

       [Column("KEYPOS")]
       public int KeyPos { get; set; }

       [Column("ISSUERLEN")]
       public int IssuerLen { get; set; }

       [Column("MODE")]
       public int Mode { get; set; }

       [Column("TERMCODETABID")]
       public int TermCodeTabId { get; set; }

       [Column("PRODCODETABID")]
       public int ProdCodeTabId { get; set; }

       [Column("RECEIPTCOUNT")]
       public int ReceiptCount { get; set; }

       [Column("OID_KEYCARDHANDLING")]
       public string OidKeyCardHandling { get; set; }


       #endregion Public Properties
   }
}
