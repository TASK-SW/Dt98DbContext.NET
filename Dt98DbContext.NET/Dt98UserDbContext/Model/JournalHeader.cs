using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TaskStar.Dt98DbContext.DT98UserDbContext.Model
{
    [PrimaryKey(nameof(Oid))]
   [Table("JOURNALHEADER")]
   public class JournalHeader
   {
      #region Public Constructors

       public JournalHeader()
      {
      }

       #endregion Public Constructors

       #region Public Properties

       [Column("OID")]
       public string Oid { get; set; }

       [Column("RECTYPE")]
       public int RecType { get; set; }

       [Column("JOURNALID")]
       public int JournalId { get; set; }

       [Column("DATETIME")]
       public DateTime DateTime { get; set; }

       [Column("TERMINALID")]
       public string TerminalId { get; set; }

       [Column("ACCOUNT")]
       public string Account { get; set; }

       [Column("CARDNUMBER")]
       public string CardNumber { get; set; }

       [Column("CARDINFO")]
       public string CardInfo { get; set; }

       [Column("NETTOTAL")]
       public decimal NetTotal { get; set; }

       [Column("TAXTOTAL")]
       public decimal TaxTotal { get; set; }

       [Column("TRACK_1")]
       public string Track1 { get; set; }

       [Column("TRACK_2")]
       public string Track2 { get; set; }

       [Column("TRACK_3")]
       public string Track3 { get; set; }

       [Column("CHIP")]
       public string Chip { get; set; }

       [Column("AMT_AUTHORIZED")]
       public decimal AmtAuthorized { get; set; }

       [Column("AMT_PAID")]
       public decimal AmtPaid { get; set; }

       [Column("LAYOUTJOURNAL")]
       public int LayoutJournal { get; set; }

       [Column("LAYOUTRECEIPT")]
       public int LayoutReceipt { get; set; }

       [Column("LAYOUTCARDINFO")]
       public int LayoutCardInfo { get; set; }

       [Column("TERMINATIONCODE")]
       public int TerminationCode { get; set; }

       [Column("ERRORCODE")]
       public int ErrorCode { get; set; }

       [Column("AMT_REST")]
       public decimal AmtRest { get; set; }

       [Column("TRXSEQNO")]
       public int TrxSeqNo { get; set; }

       [Column("TRXCOUNT")]
       public int TrxCount { get; set; }

       [Column("ARTDETAILTYPE")]
       public int ArtDetailType { get; set; }

       [Column("PAYMENTTYPE")]
       public string PaymentType { get; set; }

       [Column("LANGUAGE")]
       public int Language { get; set; }

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

       [Column("RND_TYPE")]
       public int RndType { get; set; }

       [Column("CARD_NAME")]
       public string CardName { get; set; }

       [Column("ACCOUNT_NO")]
       public string AccountNo { get; set; }

       [Column("FOREIGN_CNY")]
       public int ForeignCny { get; set; }

       [Column("DSC_TYPE")]
       public int DscType { get; set; }

       [Column("DSC_RATE")]
       public decimal DscRate { get; set; }

       [Column("DSC_AMT")]
       public decimal DscAmt { get; set; }

       [Column("DSC_AMTTOT")]
       public decimal DscAmtTot { get; set; }

       [Column("AUTH_INFO")]
       public string AuthInfo { get; set; }

       [Column("HOSTDELIVERYSTATE")]
       public int HostDeliveryState { get; set; }

       [Column("DSC_TYPE_ID")]
       public string DscTypeId { get; set; }

       [Column("DSC_TYPE_NAME")]
       public string DscTypeName { get; set; }

       [Column("DSC_REF_NO")]
       public string DscRefNo { get; set; }

       [Column("MATCH_CODE")]
       public string MatchCode { get; set; }


       #endregion Public Properties
   }
}
